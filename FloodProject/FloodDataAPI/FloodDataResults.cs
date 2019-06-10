using System.Threading.Tasks;

namespace FloodDataAPI
{
    public class FloodDataResults
    {
        public async Task<FloodDataResultModel> Get_Flood_Data_Model_By_Coordiantes(double latitude, double longitude)
        {
            FloodDataAPI API = new FloodDataAPI();
            BuildFloodResultsModel BUILD = new BuildFloodResultsModel();

            var flood_data = await API.Get_Flood_Data_By_Coordinates(latitude, longitude);
            var flood_map = await API.Get_Flood_Map_By_Coordinates(latitude, longitude); 

            var model = BUILD.Convert_Flood_API_Data_To_Flood_Model(flood_data, flood_map);

            return model;
        }
    }
}
