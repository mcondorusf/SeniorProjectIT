//Displays the info popup
Show_Popup = (view, fldInfo) => {

    var apiKey = config.API_KEY;

    if (fldInfo.hasInfo && fldInfo.zone != null) { //If flood info was found, display popup with all info
        if (fldInfo.specFldHzdArea) { //If flood insurance is required
            view.popup.open({
                title: "<h2>Location Results: </h2>",
                content:
                    "<b>Coordinates: </b>" + fldInfo.showCoordinates() + "<br><br>"
                    + "<b>Address: </b>" + fldInfo.address + "<br><br>"
                    + "<b>Flood Zone:</b> Zone " + fldInfo.zone + "<br><br>"
                    + "<b>Flood Insurance Required: </b>" + fldInfo.fldInsuranceReq() + "<br><br>"
                    + "<b>Catastrophic Flood Probability: </b>" + fldInfo.fldZoneDes + "<br><br>"
                    + "<b>Base Flood Elevation: </b>" + fldInfo.bfe + " feet" + "<br><br>"
                    + "<b>Ground Elevation: </b>" + fldInfo.getElevation() + " feet" + "<br><br>"
                    + "<b>Stilts Height: </b>" + fldInfo.stiltsHeight() + "<br><br>"
                    + "<b>Location Street View: </b><br>"
                    + "<img src=https://maps.googleapis.com/maps/api/streetview?size=400x220&location=" + fldInfo.coords.latitude
                    + "," + fldInfo.coords.longitude + "&key=" + apiKey + ">" /// call to googlemaps API for streetview
            });
        } else { //If flood insurance is not required
            view.popup.open({
                title: "<h2>Location Results: </h2>",
                content:
                    "<b>Coordinates: </b>" + fldInfo.showCoordinates() + "<br><br>"
                    + "<b>Address: </b>" + fldInfo.address + "<br><br>"
                    + "<b>Flood Zone:</b> Zone " + fldInfo.zone + "<br><br>"
                    + "<b>Flood Insurance Required: </b>" + fldInfo.fldInsuranceReq() + "<br><br>"
                    + "<b>Catastrophic Flood Probability: </b>" + fldInfo.fldZoneDes + "<br><br>"
                    + "<b>Location Street View: </b><br>"
                    + "<img src=https://maps.googleapis.com/maps/api/streetview?size=400x220&location=" + fldInfo.coords.latitude
                    + "," + fldInfo.coords.longitude + "&key=" + apiKey + ">" /// call to googlemaps API for streetview
            });
        }
    } else if (fldInfo.hasInfo && fldInfo.zone == null) { //If no flood info was found, display popup with limited info
        view.popup.open({
            title: "<h2>Location Results: </h2>",
            content:
                "<b>Coordinates: </b>" + fldInfo.showCoordinates() + "<br><br>"
                + "<b>Address: </b>" + fldInfo.address + "<br><br>"
                + "<b>There is no flood data available for this location.<br><br>"
                + "<b>Location Street View: </b><br>"
                + "<img src=https://maps.googleapis.com/maps/api/streetview?size=400x220&location=" + fldInfo.coords.latitude
                + "," + fldInfo.coords.longitude + "&key=" + apiKey + ">" /// call to googlemaps API for streetview
        });
    } else { //If API call fails, display popup notifying the user to try again
        view.popup.open({
            title: "<h2>Location Results: </h2>",
            content:
                "<b>Coordinates: </b>" + fldInfo.showCoordinates() + "<br><br>"
                + "<b>Unable to retrieve flood info for this location. Please try again.<br><br>"
                + "<b>Location Street View: </b><br>"
                + "<img src=https://maps.googleapis.com/maps/api/streetview?size=400x220&location=" + fldInfo.coords.latitude
                + "," + fldInfo.coords.longitude + "&key=" + apiKey + ">" /// call to googlemaps API for streetview
        });
    }
}