using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class BatchStateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("state")]
        public string State { get; set; }

        public BatchStateResponse(Models.Responses.BatchStateResponse response)
        {
            Id = response.Id;
            State = response.State;
        }

        public BatchStateResponse()
        {
        }
    }
}