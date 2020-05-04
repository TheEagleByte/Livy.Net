using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class BatchesResponse
    {
        [JsonProperty("from")]
        public int From { get; set; }
        
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("sessions")]
        public IEnumerable<Batch> Sessions { get; set; }

        public BatchesResponse(Models.Responses.BatchesResponse response)
        {
            From = response.From;
            Total = response.Total;
            Sessions = response.Sessions.Select(x => new Batch(x));
        }

        public BatchesResponse()
        {
        }
    }
}