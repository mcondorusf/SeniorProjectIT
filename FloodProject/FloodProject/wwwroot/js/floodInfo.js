//JS Object to hold all of the various data collected
var fldInfo = {
    hasInfo: false,
    address: " ",
    coords: 0,
    zone: " ",
    zoneDes: " ",
    fldZoneDes: " ",
    bfe: 0,
    hasBFE: false,
    specFldHzdArea: false,
    elevation: 0,
    //Function to display rounded coordinates
    showCoordinates: function () {
        var latitude = Math.round(this.coords.latitude * 100000) / 100000;
        var longitude = Math.round(this.coords.longitude * 100000) / 100000;
        return latitude + ", " + longitude;
    },
    //Function to calculate stilts height
    stiltsHeight: function () {
        if (this.specFldHzdArea && (this.elevation > this.bfe)) {
            return "Elevation already exceeds BFE";
        } else {
            var stilts = (this.bfe - this.elevation) + 0.5;
            return Math.round(stilts * 100) / 100 + " feet";
        }
    },
    //Function to display formatted specFldHzdArea value
    fldInsuranceReq: function () {
        if (this.specFldHzdArea) {
            return "Yes";
        } else {
            return "No";
        }
    },
    //Function to display elevation value
    getElevation: function () {
        if (this.elevation == null) {
            return "Unable to retrieve flood info for this location.";
        } else if (this.elevation == -1000000) {
            return "There is no elevation data available for this location.";
        } else {
            return this.elevation;
        }
    }
}


