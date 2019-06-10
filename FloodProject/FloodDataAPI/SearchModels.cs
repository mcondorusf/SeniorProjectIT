namespace FloodDataAPI
{
    public class DataCoordinatesSearchModel
    {
        /// <summary>
        /// This represents the latitude for the search. 
        /// The query will find flood information for the coordinates with this latitude. 
        /// </summary>
        public double lat { get; set; }

        /// <summary>
        /// This represents the longitude for the serach. 
        /// The query will find flood information for the coordinates with this longitude. 
        /// </summary>
        public double lng { get; set; }

        /// <summary>
        /// This represents the search type. 
        /// For coordinates searches, this should always be a coordiantes searchtype. 
        /// </summary>
        public string searchtype { get; set; } = Common.COORDS_SEARCHTYPE;

        /// <summary>
        /// This represents the getloma value. 
        /// Set to "False" or "false" to not include LOMA updates in response; default is "True". 
        /// LOMAs are often a long list of entries, so excluding the query can save time.
        /// </summary>
        public bool getloma { get; set; } = false;
    }

    public class MapCoordinatesSearchModel
    {
        /// <summary>
        /// This represents the latitude for the search. 
        /// The query will find flood information for the coordinates with this latitude. 
        /// </summary>
        public double lat { get; set; }

        /// <summary>
        /// This represents the longitude for the serach. 
        /// The query will find flood information for the coordinates with this longitude. 
        /// </summary>
        public double lng { get; set; }

        /// <summary>
        /// This represents the getbfe value as an API parameter. 
        /// When set to "True", polygons with flood zone (fld_zone) "X" will not be included in the query. 
        /// This generally makes the response load much smaller and easier to process quickly. 
        /// The default setting is for all zones, i.e. including "X", to be included in the query.
        /// </summary>
        public bool getgeojson { get; set; } = false;

        /// <summary>
        /// This represents the getloma value. 
        /// Set to "False" or "false" to not include LOMA updates in response; default is "True". 
        /// LOMAs are often a long list of entries, so excluding the query can save time.
        /// </summary>
        public bool excludex { get; set; } = false;

        /// <summary>
        /// This represents the getbfe value as an API parameter. 
        /// When set to "True" or "true", base flood elevations (BFE) will be included in geojson format. 
        /// Note: BFEs are available only in sample counties (e.g. Bergen, NJ) and are not currently maintained nationwide.
        /// </summary>
        public bool getbfe { get; set; } = true;
    }
}
