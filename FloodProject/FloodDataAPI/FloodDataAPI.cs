using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace FloodDataAPI
{
    public class FloodDataAPI
    {
        //Information for Flood Data API available at http://nationalflooddata.com/flood/floodapi/

        //Built with Flurl 
        //https://github.com/tmenier/Flurl
        //https://flurl.dev/

        public async Task<dynamic> Get_Flood_Data_By_Coordinates(double latitude, double longitude)
        {
            var url =
                Common.URL
                .WithHeader(Common.API_KEY_PARAMETER, Common.API_KEY)
                .AppendPathSegment(Common.FLOOD_DATA_API_PATH_SEGMENT)
                .SetQueryParams(new
                {
                    lat = latitude,
                    lng = longitude,
                    searchtype = Common.COORDS_SEARCHTYPE,
                    getloma = false
                });

            dynamic data = await url.GetJsonAsync();

            return data; 
        }

        public async Task<dynamic> Get_Flood_Data_By_Address(string address)
        {
            var url =
                Common.URL
                .WithHeader(Common.API_KEY_PARAMETER, Common.API_KEY)
                .AppendPathSegment(Common.FLOOD_DATA_API_PATH_SEGMENT)
                .SetQueryParams(new
                {
                    address = address,
                    searchtype = Common.ADDRESS_SEARCHTYPE,
                    getloma = false
                });

            dynamic data = await url.GetJsonAsync();

            return data;
        }
    }
}
