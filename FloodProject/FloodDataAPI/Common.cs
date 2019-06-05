namespace FloodDataAPI
{
    public class Common
    {
        /// <summary>
        /// This is the URL Endpoint for the National Flood Data API
        /// </summary>
        public const string URL = "https://api.nationalflooddata.com";

        /// <summary>
        /// This is the API Path Segment for the National Flood Data API. 
        /// This returns Fema Flood Data query information. 
        /// </summary>
        public const string FLOOD_DATA_API_PATH_SEGMENT = "data";

        /// <summary>
        /// This is the API Path Segment for the National Flood Data API. 
        /// This returns flood map content query information. 
        /// </summary>
        public const string FLOOD_MAP_API_PATH_SEGMENT = "floodmap"; 

        /// <summary>
        /// This is the API Key Parameter for the header of the API Request. 
        /// </summary>
        public const string API_KEY_PARAMETER = "x-api-key";

        /// <summary>
        /// This is the API Key for this application 
        /// when connecting to the National Flood Data API.
        /// </summary>
        public const string API_KEY = "MTNEr0YxxnbeaJ2ttc0I5lLlAj5R0BP9z24rj0qf";

        /// <summary>
        /// This represents a search type by coordinates when querying 
        /// the National Flood Data API. 
        /// </summary>
        public const string COORDS_SEARCHTYPE = "coord";

        /// <summary>
        /// This represents a search type by address when querying 
        /// the National Flood Data API. 
        /// </summary>
        public const string ADDRESS_SEARCHTYPE = "addressparcel";
    }
}
