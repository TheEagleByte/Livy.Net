using System.Collections.Generic;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class SessionCompletionResponse
    {
        [JsonProperty("candidates")]
        public IEnumerable<string> Candidates { get; set; }

        public SessionCompletionResponse(Models.Responses.SessionCompletionResponse response)
        {
            Candidates = response.Candidates;
        }
    }
}