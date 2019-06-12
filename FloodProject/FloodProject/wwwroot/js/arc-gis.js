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

        var layer = new MapLayer({ // Adds in FEMA FIRM map layer
            url: "https://hazards.fema.gov/gis/nfhl/rest/services/public/NFHL/MapServer",

            sublayers: [
              {
                id: 28, // Flood Hazard Zones layer
                visible: true
              },
              {
                id: 27,
                visible: true // Flood Hazard Boundaries layer
              },
              {
                id: 16,  // Base Flood Elevations layer
                visible: true
              }
            ]
        });

        var search = new Search({ // Creates search widget
            view: view,
        });

        var legend = new Legend({ // Creates legend widget
            view: view
        });

        map.add(layer); //Displays FEMA FIRM layer
 
        view.ui.add(search, "top-right"); //Places search widget

        view.ui.add(legend, "bottom-left"); //Places legend widget

        Setup_About_Button(view); 

        Setup_Custom_Search_Response(view, search); // Fires search functions
    });
};

Setup_About_Button = (view) => {
    var search_button = document.createElement("BUTTON");
    search_button.innerHTML = "?";
    search_button.id = "search_button";
    search_button.title = "Click this button to find out more about how the application works."; 
    search_button.onclick = function () { window.open("Home/About", "_blank"); };

    view.ui.add(search_button, "bottom-right"); //Places button
}; 