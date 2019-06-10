using System.Collections.Generic;

namespace FloodDataAPI
{
    //Flood Data Response object from: http://nationalflooddata.com/flood/floodmapapi/

    public class FloodMapResponse
    {
        /// <summary>
        /// response status code (string)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// list of one or more results (list of dictionaries)
        /// </summary>
        public FloodMapResult result { get; set; }
    }

    public class FloodMapResult
    {
        /// <summary>
        /// list format with keys
        /// </summary>
        public List<Bfelist> bfelist { get; set; }

        /// <summary>
        /// list format with keys
        /// </summary>
        public List<Floodregion> floodregions { get; set; }
    }

    public class Bfelist
    {
        /// <summary>
        /// line identifier
        /// </summary>
        public string bfe_ln_id { get; set; }

        /// <summary>
        /// vertical datum
        /// https://en.wikipedia.org/wiki/Template:NGVD29
        /// </summary>
        public string v_datum { get; set; }

        /// <summary>
        /// shortest distance from query point to line in km
        /// </summary>
        public double distkm { get; set; }

        /// <summary>
        /// version identifier
        /// </summary>
        public string version_id { get; set; }

        /// <summary>
        /// source citation
        /// </summary>
        public string source_cit { get; set; }

        /// <summary>
        /// BFE lines in geojson
        /// </summary>
        public string geojson { get; set; }

        /// <summary>
        /// elevation in feet
        /// </summary>
        public double elev { get; set; }

        /// <summary>
        /// flood insurance rate map id
        /// </summary>
        public string dfirm_id { get; set; }

        public string len_unit { get; set; }

        /// <summary>
        /// polygon id
        /// </summary>
        public int ogc_fid { get; set; }
    }

    public class Floodregion
    {
        public string fld_ar_id { get; set; }

        /// <summary>
        /// shortest distance from query point to polygon in km
        /// </summary>
        public double distkm { get; set; }

        /// <summary>
        /// flood polygon in geojson
        /// </summary>
        public string geojson { get; set; }

        /// <summary>
        /// zone description
        /// </summary>
        public string zone_subty { get; set; }

        /// <summary>
        /// flood zone
        /// </summary>
        public string fld_zone { get; set; }

        /// <summary>
        /// flood insurance rate map id
        /// </summary>
        public string dfirm_id { get; set; }

        /// <summary>
        /// polygon id
        /// </summary>
        public int ogc_fid { get; set; }
    }
}
