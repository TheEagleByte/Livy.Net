namespace Livy.Net
{
    public class LivyClientConfiguration
    {
        /// <summary>
        /// The base URL for the Livy REST API
        /// Example: https://%clusterName%.azurehdinsight.net/livy
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Username to access the Livy API
        /// </summary>
        public string Username { get; set; }
        
        /// <summary>
        /// Password to access the Livy API
        /// </summary>
        public string Password { get; set; }
    }
}