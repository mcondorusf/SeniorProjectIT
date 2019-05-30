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

        private const string API_LAT = "lat";
        private const string API_LONG = "lng";
        private const string API_SEARCH_TYPE = "searchtype";

        private const string COORDS_SEARCHTYPE = "coord";


        public async Task<dynamic> GetResponse()
        {
            var url =
                URL
                .AppendPathSegment("data")
                .SetQueryParams(new
                {
                    API_KEY_PARAMETER = API_KEY,
                    API_LAT = -82.7344711,
                    API_LONG = 27.9941986,
                    API_SEARCH_TYPE = COORDS_SEARCHTYPE
                });

            dynamic data = await url.GetJsonAsync();

            return data; 
        }
    }
}
