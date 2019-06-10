using System.Collections.Generic;

namespace FloodDataAPI
{
    public class FloodMapResponse
    {
        public string status { get; set; }
        public FloodMapResult result { get; set; }
    }

    public class FloodMapResult
    {
        public List<Bfelist> bfelist { get; set; }
        public List<Floodregion> floodregions { get; set; }
    }

    public class Bfelist
    {
        public string bfe_ln_id { get; set; }
        public string v_datum { get; set; }
        public double distkm { get; set; }
        public string version_id { get; set; }
        public string source_cit { get; set; }
        public string geojson { get; set; }
        public double elev { get; set; }
        public string dfirm_id { get; set; }
        public string len_unit { get; set; }
        public int ogc_fid { get; set; }
    }

    public class Floodregion
    {
        public string fld_ar_id { get; set; }
        public double distkm { get; set; }
        public string geojson { get; set; }
        public string zone_subty { get; set; }
        public string fld_zone { get; set; }
        public string dfirm_id { get; set; }
        public int ogc_fid { get; set; }
    }
}
