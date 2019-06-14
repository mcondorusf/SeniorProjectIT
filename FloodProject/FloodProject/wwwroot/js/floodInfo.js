//JS Object to hold all of the various data collected
var fldInfo = {
    hasInfo: false,
    address: " ",
    coords: 0,
    zone: " ",
    zoneDes: " ",
    bfe: 0,
    specFldHzdArea: false,
    elevation: 0,
    stiltsHeight: function () {
        return "Testing";
    },
    fldInsuranceReq: function () {
        if (this.specFldHzdArea) {
            return "True";
        } else {
            return "False";
        }
    }
}