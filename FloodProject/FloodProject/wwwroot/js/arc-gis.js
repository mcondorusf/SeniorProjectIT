//This fires when the document loads. 
$(document).ready(function () {
    Create_Map(); 
});

Create_Map = () => {
    require([
        "esri/Map",
        "esri/views/MapView",
        "esri/widgets/Search", //Adds the map search function to ArgGIS
        "esri/widgets/Legend",
        "esri/layers/MapImageLayer", //Adds map image layer function
        "esri/layers/support/Sublayer"
    ], function (Map, MapView, Search, Legend, MapLayer, Sublayer) {

        var map = new Map({
            basemap: "topo-vector"
        });

        var view = new MapView({
            container: "GIS-Map",
            map: map,
            center: [-82.41302, 28.05462], //This is the lat/long for University of South Florida
            zoom: 15 //This zoom level shows the flood layers and legend.  Higher numbers = more zoomed in. 
        });

        // Adds feature layer to basemap
        var layer = new MapLayer({
            url: "https://hazards.fema.gov/gis/nfhl/rest/services/public/NFHL/MapServer",
            /// Limit sublayers displayed to those listed
            /// Ideally what layers to show will be togglable in the future
            sublayers: [
              {
                id: 28, // Flood Hazard Zones layer
                visible: true
              },
              {
                id: 16,  // Base Flood Elevations layer
                visible: true
              }
            ]
        });


        // Search widget
        var search = new Search({
            view: view,
        });
        /// On search complete pass/receive data from HomeController
        /// using ajax and update the search popup content
        search.on("search-complete", function (event) {
            $.ajax({
                url: 'Home/GetFloodDataByAddress',
                type: 'GET',
                traditional: true,
                data: event.searchTerm,
                success: function (data) {
                    search.popupTemplate.content = "<h1>" + data.data + "</h1>";
                },
                error: function () {
                    // Hope this works
                }
            });
            search.popupTemplate.content = event.searchTerm;
        });

        // Legend widget
        var legend = new Legend({
            view: view
        });

        // Adds the layer defined abocve as an overlay on the basemap
        map.add(layer);
        // Displays the search widget created above
        view.ui.add(search, "top-right");
        // Displays the legend widget created above
        view.ui.add(legend, "bottom-left");
        // Fires click to search 
        Setup_Click_To_Search(view, search);
    });
}; 

Setup_Click_To_Search = (view, search) => {
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
    /// Pass/receive data from HomeController using ajax
    /// and update the on-click popup content
    function showPopup(address, pt) {
        $.ajax({
            url: 'Home/GetFloodDataByCoordinates',
            type: 'GET',
            dataType: 'json',
            traditional: true,
            data: {
                latitude: pt.latitude,
                longitude: pt.longitude
            },
            success: function (data) {
                view.popup.open({
                    title: "Coords: " + Math.round(pt.longitude * 100000) / 100000 + "," + Math.round(pt.latitude * 100000) / 100000,
                    content: address + "<h1>" + data.data + "</h1>"
                });
            },
            error: function () {
                //Swallow it, who cares lolz
            }
        });
    }
 
};