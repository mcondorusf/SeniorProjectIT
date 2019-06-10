using Newtonsoft.Json;
using System.Collections.Generic;

namespace FloodDataAPI
{
    public class FloodDataResponse
    {
        /// <summary>
        /// response status code (string)
        /// </summary>
        public string status { get; set; }
        public object parceladdress { get; set; }
        public Geocode geocode { get; set; }
        public Coords coords { get; set; }
        public Result result { get; set; }
        public List<object> loma { get; set; }
        public Request request { get; set; }
        public string mappng { get; set; }
    }

    public class Request
    {
        public string searchtype { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string apn { get; set; }
        public string address { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Coords
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Result
    {
        [JsonProperty("flood.s_firm_pan")]
        public List<FloodSFirmPan> s_firm_pan { get; set; }

        public string firm { get; set; }

        [JsonProperty("flood.s_fld_haz_ar")]
        public List<FloodSFldHazAr> s_fld_haz_ar { get; set; }

        [JsonProperty("flood.s_pol_ar")]
        public List<FloodSPolAr> s_pol_ar { get; set; }


        public string regemer_sanction { get; set; }
        public string tribal { get; set; }
        public string census_block { get; set; }
        public bool comm_part { get; set; }
        public string fhbm { get; set; }
        public string comm_name { get; set; }
        public string curreff { get; set; }
        public object notes { get; set; }
    }

    public class Geocode
    {
    }

    public class FloodSFirmPan
    {
        public string suffix { get; set; }
        public object pnp_reason { get; set; }
        public string firm_pan { get; set; }
        public string eff_date { get; set; }
        public string firm_id { get; set; }
        public string dfirm_id { get; set; }
        public string st_fips { get; set; }
        public string panel_typ { get; set; }
        public string panel { get; set; }
    }

    public class FloodSFldHazAr
    {
        public string fld_ar_id { get; set; }
        public string version_id { get; set; }
        public string sfha_tf { get; set; }
        public string zone_subty { get; set; }
        public string source_cit { get; set; }
        public string fld_zone { get; set; }
        public string dfirm_id { get; set; }
    }

    public class FloodSPolAr
    {
        public string comm_no { get; set; }
        public string pol_name1 { get; set; }
        public string co_fips { get; set; }
        public string cid { get; set; }
        public string com_nfo_id { get; set; }
        public string pol_ar_id { get; set; }
    }
}
