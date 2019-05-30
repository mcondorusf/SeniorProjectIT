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

        private const string URL = "https://api.nationalflooddata.com";
        public const string API_KEY_PARAMETER = "x-api-key"; 
        private const string API_KEY = "MTNEr0YxxnbeaJ2ttc0I5lLlAj5R0BP9z24rj0qf";
        private const string COORDS_SEARCHTYPE = "coord";


        public async Task<dynamic> Get_Flood_Data_By_Coordinates(double latitude, double longitude)
        {
            var url =
                URL
                .WithHeader(API_KEY_PARAMETER, API_KEY)
                .AppendPathSegment("data")
                .SetQueryParams(new
                {
                    lat = latitude,
                    lng = longitude,
                    searchtype = COORDS_SEARCHTYPE
                });

            dynamic data = await url.GetJsonAsync();

            return data; 
        }
    }
}
