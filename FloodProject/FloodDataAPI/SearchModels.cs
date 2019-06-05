namespace FloodDataAPI
{
    public class AddressSearchModel
    {
        /// <summary>
        /// This represents the address for the search.  
        /// The query will find flood information for this address. 
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// This represents the search type. 
        /// For address searches, this should always be an address searchtype. 
        /// </summary>
        public string searchtype { get; set; } = Common.ADDRESS_SEARCHTYPE;

        /// <summary>
        /// This represents the getloma value. 
        /// Set to "False" or "false" to not include LOMA updates in response; default is "True". 
        /// LOMAs are often a long list of entries, so excluding the query can save time.
        /// </summary>
        public bool getloma { get; set; } = false;
    }

    public class CoordinatesSearchModel
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
}
