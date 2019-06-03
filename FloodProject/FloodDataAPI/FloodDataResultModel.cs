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
        /// This is the description of the Flood Zone from the API Result. 
        /// These descritions come from http://nationalflooddata.com/flood/floodzone/
        /// They provide the description for the Flood Zone code. 
        /// </summary>
        public string FloodZoneDesciption => Get_Flood_Zone_Description(FloodZone);

        /// <summary>
        /// This comes from the Flood Data API
        /// Object: s_fld_haz_ar
        /// Property: sfha_tf
        /// Description: special flood hazard area
        /// It returns true or false. 
        /// FROM: https://www.fema.gov/special-flood-hazard-area
        /// The SFHA is the area where the National Flood Insurance Program's (NFIP's) floodplain management regulations 
        /// must be enforced and the area where the mandatory purchase of flood insurance applies. 
        /// The SFHA includes Zones A, AO, AH, A1-30, AE, A99, AR, AR/A1-30, AR/AE, AR/AO, AR/AH, AR/A, VO, V1-30, VE, and V.
        /// </summary>
        public Boolean SpecialFloodHazardArea { get; set; }

        /// <summary>
        /// This comes from the Flood Data API
        /// Object: s_fld_haz_ar
        /// Property: zone_subty
        /// Description: text description of zone, available occasionally
        /// </summary>
        public string ZoneDescription { get; set; }

        /// <summary>
        /// This gets a description for a flood code. 
        /// These descritions come from http://nationalflooddata.com/flood/floodzone/
        /// They provide the description for the Flood Zone code. 
        /// If no flood zone description it will return an empty string. 
        /// </summary>
        public string Get_Flood_Zone_Description(string flood_code)
        {
            switch (flood_code)
            {
                case "A":
                    return
                        "An area with a 1% annual chance of flood; " +
                        "does not have base flood elevations (BFEs) available.";

                case "AE":
                    return
                        "An area with a 1% annual chance of flood; " +
                        "base flood elevations BFEs are available.";

                case "AH":
                    return
                        "An area with a 1% annual chance of flood with flood depths ranging from 1 to 3 feet, " +
                        "generally near pond or pooling areas. BFEs are available.";

                case "AO":
                    return
                        "An area with a 1% annual chance of flood with flood depths ranging from 1 to 3 feet, " +
                        "generally sheet flow on sloping terrain. BFEs are available.";

                case "AR":
                    return
                        "An area inundated by flooding, for which BFEs or average depths have been determined. " +
                        "This is an area that was previously, and will again, be protected from the 1% annual chance flood " +
                        "by a Federal flood protection system whose restoration is Federally funded and underway";

                case "A1":
                case "A2":
                case "A3":
                case "A4":
                case "A5":
                case "A6":
                case "A7":
                case "A8":
                case "A9":
                case "A10":
                case "A11":
                case "A12":
                case "A13":
                case "A14":
                case "A15":
                case "A16":
                case "A17":
                case "A18":
                case "A19":
                case "A20":
                case "A21":
                case "A22":
                case "A23":
                case "A24":
                case "A25":
                case "A26":
                case "A27":
                case "A28":
                case "A29":
                case "A30":
                    return
                        "An area with a 1% annual chance flooding, for which BFEs have been determined.";

                case "B":
                case "X500":
                    return
                        "An area with at least a 0.2% chance of annual flood or with a 1% annual chance of flood " +
                        "with average depths less that one foot or with drainage area less than one square mile.";

                case "C":
                case "X":
                    return
                        "An area outside the 0.2% and 1% annual chance of flood regions.";

                case "D":
                    return
                        "An area where flooding is possible but has not been studied.";

                case "V":
                    return
                        "An area with a 1% annual chance flooding with velocity hazard due to waves; " +
                        "BFEs have are not available.";

                case "VE":
                case "V1":
                case "V2":
                case "V3":
                case "V4":
                case "V5":
                case "V6":
                case "V7":
                case "V8":
                case "V9":
                case "V10":
                case "V11":
                case "V12":
                case "V13":
                case "V14":
                case "V15":
                case "V16":
                case "V17":
                case "V18":
                case "V19":
                case "V20":
                case "V21":
                case "V22":
                case "V23":
                case "V24":
                case "V25":
                case "V26":
                case "V27":
                case "V28":
                case "V29":
                case "V30":
                    return
                        "An area with a 1% annual chance flooding with velocity hazard due to waves; " +
                        "BFEs have are available.";

                default:
                    return String.Empty;
            }
        }
    }

}
