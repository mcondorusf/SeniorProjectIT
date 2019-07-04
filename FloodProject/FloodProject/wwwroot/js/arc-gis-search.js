Setup_Custom_Search_Response = (view, search) => {
    // Click to Search
    view.on("click", function (evt) {
        search.clear();
        view.popup.clear();
        if (search.activeSource) {
            var geocoder = search.activeSource.locator; // World geocode service
            geocoder.locationToAddress(evt.mapPoint)
                .then(function (response) {
                    fldInfo.address = response.address;
                    queryApi(evt.mapPoint);
                }, function (err) { // Show no address found
                    fldInfo.address = "No address found";
                    queryApi(evt.mapPoint);
                });
        }
    });

    // Manual Search
    search.on("search-complete", function (event) {
        var coords = event.results[0].results[0].feature.geometry;
        if (search.activeSource) {
            var geocoder = search.activeSource.locator; // World geocode service
            geocoder.locationToAddress(coords)
                .then(function (response) {
                    fldInfo.address = response.address;
                    queryApi(coords);
                }, function (err) { // Show no address found
                    fldInfo.address = "No address found";
                    queryApi(coords);
                });
        }
    });

    /// Pass/receive data from HomeController using ajax
    /// and updates the popup content
    function queryApi(coords) {
        Show_Loading_Overlay(view);

        fldInfo.coords = {
            latitude: coords.latitude,
            longitude: coords.longitude
        }

        var elevApiUrl = "https://ned.usgs.gov/epqs/pqs.php?x=" + coords.longitude
            + "&y=" + coords.latitude + "&units=Feet&output=json";

        //National Flood Data API call
        $.ajax({ 
            url: 'Home/GetFloodDataByCoordinates',
            type: 'GET',
            dataType: 'json',
            traditional: true,
            data: {
                latitude: coords.latitude,
                longitude: coords.longitude
            },
            success: function (response) {
                fldInfo.hasInfo = true
                fldInfo.zone = response.data.floodZone;
                fldInfo.zoneDes = response.data.zoneDescription;
                fldInfo.fldZoneDes = response.data.floodZoneDesciption;
                fldInfo.bfe = response.data.elevation;
                fldInfo.hasBFE = response.data.baseFloodElevationAvailable; 
                fldInfo.specFldHzdArea = response.data.specialFloodHazardArea;

                //USGS Elevation API call
                $.ajax({
                    url: elevApiUrl,
                    type: 'GET',
                    success: function (response) {
                        fldInfo.elevation = response.USGS_Elevation_Point_Query_Service.Elevation_Query.Elevation;
                        Show_Popup(view, fldInfo);
                    },
                    error: function () {
                        fldInfo.elevation = null;
                    }
                 });
            },
            error: function () {
                fldInfo.hasInfo = false;
                Show_Popup(view, fldInfo)
            }
        });
    }

};

//This shows popup with a loading overlay. 
//Intended to use when we do a search with API calls. 
//This lets the user know we are working on collecting data. 
Show_Loading_Overlay = (view) => {
    view.popup.open({
        title: "<h2>Location Results: </h2>",
        content: "<div class='loader'></div>"
    });
}