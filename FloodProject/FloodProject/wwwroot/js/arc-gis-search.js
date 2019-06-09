Setup_Custom_Search_Response = (view, search) => {
    // Click to Search
    view.on("click", function (evt) {
        search.clear();
        view.popup.clear();
        if (search.activeSource) {
            var geocoder = search.activeSource.locator; // World geocode service
            geocoder.locationToAddress(evt.mapPoint)
                .then(function (response) {
                    var address = response.address;
                    showPopup(address, evt.mapPoint);
                }, function (err) { // Show no address found
                    showPopup("No address found.", evt.mapPoint);
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
                    var address = response.address;
                    showPopup(address, coords);
                }, function (err) { // Show no address found
                    showPopup("No address found.", coords);
                });
        }
    });

    /// Pass/receive data from HomeController using ajax
    /// and updates the popup content
    function showPopup(address, coords) {
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
                view.popup.open({
                    title: "<h2>Location Results: </h2>",
                    content: "<b>Coordinates: </b>" + Math.round(coords.longitude * 100000) / 100000 + ", "
                        + Math.round(coords.latitude * 100000) / 100000 + "<br><br>"
                        + "<b>Address: </b>" + address + "<br><br>"
                        + "<b>Flood Zone:</b> Zone " + response.data.floodZone + "<br><br>"
                        + "<b>Catastrophic Flood Probability: </b>" + response.data.floodZoneDesciption + "<br><br>"
                        + "<b>Base Flood Elevation: </b>" + null + "<br><br>"//placeholder for BFE
                        + "<b>Flood Insurance Required? </b>" + response.data.specialFloodHazardArea
                });
            },
            error: function () {
                //Swallow it, who cares lolz
            }
        });
    }

};