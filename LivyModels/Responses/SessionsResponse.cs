using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class SessionsResponse
    {
        [JsonProperty("from")]
        public int From { get; set; }
        
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("sessions")]
        public IEnumerable<Session> Sessions { get; set; }

        public SessionsResponse(Models.Responses.SessionsResponse response)
        {
            From = response.From;
            Total = response.Total;
            Sessions = response.Sessions.Select(x => new Session(x));
        }

        public SessionsResponse()
        {
        }
    }
}