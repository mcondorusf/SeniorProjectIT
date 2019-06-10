using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace FloodDataAPI
{
    public class FloodDataAPI
    {
        //Information for Flood Data API available at http://nationalflooddata.com/flood/floodapi/

        //Built with Flurl 
        //https://github.com/tmenier/Flurl
        //https://flurl.dev/

        internal async Task<FloodDataResponse> Get_Flood_Data_By_Coordinates(double latitude, double longitude)
        {
            var url =
                Common.URL
                .WithHeader(Common.API_KEY_PARAMETER, Common.API_KEY)
                .AppendPathSegment(Common.FLOOD_DATA_API_PATH_SEGMENT)
                .SetQueryParams(new DataCoordinatesSearchModel
                {
                    lat = latitude,
                    lng = longitude
                });

            FloodDataResponse data = await url.GetJsonAsync<FloodDataResponse>();

            dynamic test_data = await url.GetJsonAsync(); 
            string json = JsonConvert.SerializeObject(test_data);

            return data; 
        }

        internal async Task<FloodMapResponse> Get_Flood_Map_By_Coordinates(double latitude, double longitude)
        {
            var url =
                Common.URL
                .WithHeader(Common.API_KEY_PARAMETER, Common.API_KEY)
                .AppendPathSegment(Common.FLOOD_MAP_API_PATH_SEGMENT)
                .SetQueryParams(new MapCoordinatesSearchModel
                {
                    lat = latitude,
                    lng = longitude
                });

            FloodMapResponse data = await url.GetJsonAsync<FloodMapResponse>();

            return data;
        }
    }
}
