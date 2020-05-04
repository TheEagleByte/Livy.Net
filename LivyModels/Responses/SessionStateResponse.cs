using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class SessionStateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("state")]
        public SessionState State { get; set; }

        public SessionStateResponse(Models.Responses.SessionStateResponse response)
        {
            Id = response.Id;
            State = (SessionState)response.State;
        }

        public SessionStateResponse()
        {
        }
    }
}