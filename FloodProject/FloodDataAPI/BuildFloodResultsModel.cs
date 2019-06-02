using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloodDataAPI
{
    public class BuildFloodResultsModel
    {
        private IDictionary<string, object> Get_Flood_Data_From_API_Result(dynamic data)
        {
            //For looking at a National Flood Data Result object check: 
            //http://nationalflooddata.com/flood/floodapi/#response

            //Convert the dynamic result from the Flood Data API to a dictionary. 
            IDictionary<string, object> dictionary_data = data;

            //Get the result object from the Flood Data dyanmic object
            //FROM API DOCS: result = list of one or more results (list of dictionaries)
            IDictionary<string, object> result = (IDictionary<string, object>)dictionary_data["result"];

            //Get the flood information from the result. 
            //FROM API DOCS: s_fld_haz_ar = list of fields from the intersection with FEMA layer s_fld_haz_ar; one dictionary per intersection (details below)
            IList flood_result = (IList)result["flood.s_fld_haz_ar"];

            //Cast the List of results to an Enumerable of Dictionaries. 
            IEnumerable<IDictionary<string, object>> items = flood_result.Cast<IDictionary<string, object>>();

            //Take the first result. 
            return items.FirstOrDefault();
        }

        private FloodDataResultModel Build_Result_Model_From_Flood_Data(IDictionary<string, object> data)
        {
            return new FloodDataResultModel
            {
                FloodInsuranceRateMapId = data["dfirm_id"].ToString(),
                FloodZone = data["fld_zone"].ToString(),
                SpecialFloodHazardArea = data["sfha_tf"].ToString(),
                ZoneDescription = data["zone_subty"].ToString()
            }; 
        }

        public FloodDataResultModel Convert_Flood_API_Data_To_Flood_Model(dynamic data)
        {
            var information = Get_Flood_Data_From_API_Result(data);

            return Build_Result_Model_From_Flood_Data(information); 
        }
    }
}
