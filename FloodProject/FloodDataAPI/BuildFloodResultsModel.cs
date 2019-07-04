using System.Linq;

namespace FloodDataAPI
{
    public class BuildFloodResultsModel
    {
        internal FloodDataResultModel Convert_Flood_API_Data_To_Flood_Model(FloodDataResponse flood_data, FloodMapResponse flood_map)
        {
            FloodDataResultModel model = new FloodDataResultModel();

            Convert_Flood_Data_To_Model_Properties(flood_data, model);

            Convert_Flood_Data_To_Model_Properties(flood_map, model); 

            return model; 
        }

        private FloodDataResultModel Convert_Flood_Data_To_Model_Properties(FloodDataResponse flood_data, FloodDataResultModel model)
        {
            var flood_data_result =
                flood_data.result
                .s_fld_haz_ar
                .FirstOrDefault();

            if (flood_data_result != null)
            {
                model.FloodInsuranceRateMapId = flood_data_result.dfirm_id;
                model.FloodZone = flood_data_result.fld_zone;
                model.SpecialFloodHazardArea = flood_data_result.sfha_tf == "T" ? true : false;
                model.ZoneDescription = flood_data_result.zone_subty;
            }

            return model; 
        }

        private FloodDataResultModel Convert_Flood_Data_To_Model_Properties(FloodMapResponse flood_map, FloodDataResultModel model)
        {
            var flood_map_result =
                flood_map
                .result
                .bfelist
                .FirstOrDefault();

            if (flood_map_result != null)
            {
                model.Elevation = flood_map_result.elev;
                model.BaseFloodElevationAvailable = true; 
            }

            return model;
        }
    }
}
