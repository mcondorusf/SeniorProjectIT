//Displays the info popup
Show_Popup = (view, fldInfo) => {

    var apiKey = config.API_KEY;

    if (fldInfo.hasInfo) { //If flood info was found, display popup with all info
        view.popup.open({
            title: "<h2>Location Results: </h2>",
            content:
                "<b>Coordinates: </b>" + fldInfo.coords.longitude + ", " + fldInfo.coords.latitude + "<br><br>"
                + "<b>Address: </b>" + fldInfo.address + "<br><br>"
                + "<b>Flood Zone:</b> Zone " + fldInfo.zone + "<br><br>"
                + "<b>Catastrophic Flood Probability: </b>" + fldInfo.zoneDes + "<br><br>"
                + "<b>Base Flood Elevation: </b>" + fldInfo.bfe + " feet" + "<br><br>"
                + "<b>Ground Elevation: </b>" + fldInfo.elevation + " feet" + "<br><br>"
                + "<b>Flood Insurance Required? </b>" + fldInfo.specFldHzdArea + "<br><br>"
                + "<b>Location Street View: </b><br>"
                + "<img src=https://maps.googleapis.com/maps/api/streetview?size=400x220&location=" + fldInfo.coords.latitude
                + "," + fldInfo.coords.longitude + "&key=" + apiKey + ">" /// call to googlemaps API for streetview
        });
    } else { //If no flood info was found, display popup with limited info

        view.popup.open({
            title: "<h2>Location Results: </h2>",
            content:
                "<b>Coordinates: </b>" + fldInfo.coords.longitude + ", " + fldInfo.coords.latitude + "<br><br>"
                + "<b>Address: </b>" + fldInfo.address + "<br><br>"
                + "<b>Unable to retrieve flood data for location.<br><br>"
                + "<b>Location Street View: </b><br>"
                + "<img src=https://maps.googleapis.com/maps/api/streetview?size=400x220&location=" + fldInfo.coords.latitude
                + "," + fldInfo.coords.longitude + "&key=" + apiKey + ">" /// call to googlemaps API for streetview
        });
    }

}