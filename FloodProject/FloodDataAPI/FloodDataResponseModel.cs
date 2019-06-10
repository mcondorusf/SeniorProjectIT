using Newtonsoft.Json;
using System.Collections.Generic;

namespace FloodDataAPI
{
    //Flood Data Response object from: http://nationalflooddata.com/flood/floodapi/

    public class FloodDataResponse
    {
        /// <summary>
        /// response status code (string)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// address of the parcel (dictionary)
        /// Fields: addr_number, addr_street_prefix, addr_street_name, addr_street_suffix, 
        /// addr_street_type, county_name, county_id, muni_name, parcel_id, physcity, physzip, state_abbr
        /// </summary>
        public object parceladdress { get; set; }

        /// <summary>
        /// geocode details for searchtypes addresscoord and addressparcel (dictionary)
        /// </summary>
        public Geocode geocode { get; set; }

        /// <summary>
        /// lat/lng, centroid of parcel for searchtypes 'addressparcel', 'coordparcel' and 'parcel' (dictionary)
        /// </summary>
        public Coords coords { get; set; }

        /// <summary>
        /// list of one or more results (list of dictionaries)
        /// </summary>
        public Result result { get; set; }

        public List<object> loma { get; set; }

        /// <summary>
        /// initial request parameters (dictionary)
        /// </summary>
        public Request request { get; set; }

        /// <summary>
        /// hyperlink to map png file for searchtype addresscoord
        /// </summary>
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
        /// <summary>
        /// list of fields from the intersection with FEMA layer s_firm_pan; one dictionary per intersection (details below)
        /// </summary>
        [JsonProperty("flood.s_firm_pan")]
        public List<FloodSFirmPan> s_firm_pan { get; set; }

        /// <summary>
        /// Date of first flood insruance rate map. Returned as unformatted text.
        /// </summary>
        public string firm { get; set; }

        /// <summary>
        /// list of fields from the intersection with FEMA layer s_fld_haz_ar; one dictionary per intersection (details below)
        /// </summary>
        [JsonProperty("flood.s_fld_haz_ar")]
        public List<FloodSFldHazAr> s_fld_haz_ar { get; set; }

        /// <summary>
        /// list of fields from the intersection with FEMA layer s_pol_ar; one dictionary per intersection (details below)
        /// </summary>
        [JsonProperty("flood.s_pol_ar")]
        public List<FloodSPolAr> s_pol_ar { get; set; }

        public string regemer_sanction { get; set; }

        /// <summary>
        /// Whether or not the community is identified as Tribal in the NFIP Community Status Book
        /// </summary>
        public string tribal { get; set; }

        /// <summary>
        /// census tract number (State id + county id + census tract + block group number)
        /// </summary>
        public string census_block { get; set; }

        /// <summary>
        /// community participation: True or False. See the NFIP Community Status Book
        /// </summary>
        public bool comm_part { get; set; }

        /// <summary>
        /// Date of first flood hazard boundary map. Returned as unformatted text.
        /// </summary>
        public string fhbm { get; set; }

        public string comm_name { get; set; }

        /// <summary>
        /// Date current firm became effective. Returned as unformatted text. 
        /// Can be several weeks into the future, in which case (>) follows the date. 
        /// The date may also be followed by (M) for "No elevation determined", (S) for "Suspended Community" or (E) for "Indicates Entry in Emergency Program"notes
        /// </summary>
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

        /// <summary>
        /// NFIP Map Number of Community-Panel Number onb a Standard Flood Hazard Determination Form
        /// </summary>
        public string firm_pan { get; set; }

        /// <summary>
        /// effective date
        /// </summary>
        public string eff_date { get; set; }

        /// <summary>
        /// polygon id
        /// </summary>
        public string firm_id { get; set; }

        /// <summary>
        /// flood insurance rate map id
        /// </summary>
        public string dfirm_id { get; set; }

        /// <summary>
        /// state id or fips
        /// </summary>
        public string st_fips { get; set; }

        /// <summary>
        /// panel type (e.g. countywide, village, city)
        /// </summary>
        public string panel_typ { get; set; }

        /// <summary>
        /// panel
        /// </summary>
        public string panel { get; set; }
    }

    public class FloodSFldHazAr
    {
        /// <summary>
        /// polygon id
        /// </summary>
        public string fld_ar_id { get; set; }

        /// <summary>
        /// version id
        /// </summary>
        public string version_id { get; set; }

        /// <summary>
        /// special flood hazard area
        /// </summary>
        public string sfha_tf { get; set; }

        /// <summary>
        /// text description of zone, available occasionally
        /// </summary>
        public string zone_subty { get; set; }

        /// <summary>
        /// source
        /// </summary>
        public string source_cit { get; set; }

        /// <summary>
        /// flood zone
        /// </summary>
        public string fld_zone { get; set; }

        /// <summary>
        /// flood insurance rate map id
        /// </summary>
        public string dfirm_id { get; set; }
    }

    public class FloodSPolAr
    {
        /// <summary>
        /// community number
        /// </summary>
        public string comm_no { get; set; }

        /// <summary>
        /// municipal name, e.g. city or county
        /// </summary>
        public string pol_name1 { get; set; }

        /// <summary>
        /// county id or county fips
        /// </summary>
        public string co_fips { get; set; }

        /// <summary>
        /// community id or number
        /// </summary>
        public string cid { get; set; }

        /// <summary>
        /// community id (state id + community number)
        /// </summary>
        public string com_nfo_id { get; set; }

        /// <summary>
        /// polygon id
        /// </summary>
        public string pol_ar_id { get; set; }
    }
}
