using System;
using System.Collections.Generic;
using System.Text;

namespace FloodDataAPI
{
    public class FloodDataResultModel
    {
        /// <summary>
        /// This comes from the Flood Data API
        /// Object: s_fld_haz_ar
        /// Property: dfirm_id
        /// Description: flood insurance rate map id
        /// </summary>
        public string FloodInsuranceRateMapId { get; set; }

        /// <summary>
        /// This comes from the Flood Data API
        /// Object: s_fld_haz_ar
        /// Property: fld_zone
        /// Description: flood zone
        /// </summary>
        public string FloodZone { get; set; }

        /// <summary>
        /// This comes from the Flood Data API
        /// Object: s_fld_haz_ar
        /// Property: sfha_tf
        /// Description: special flood hazard area
        /// </summary>
        public string SpecialFloodHazardArea { get; set; }

        /// <summary>
        /// This comes from the Flood Data API
        /// Object: s_fld_haz_ar
        /// Property: zone_subty
        /// Description: text description of zone, available occasionally
        /// </summary>
        public string ZoneDescription { get; set; }
    }
}
