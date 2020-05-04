using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Requests
{
    public class SessionCompletionRequest
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        
        [JsonProperty("kind")]
        public SessionKind Kind { get; set; }
        
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        public SessionCompletionRequest(Models.Requests.SessionCompletionRequest request)
        {
            Code = request.Code;
            Kind = (SessionKind) request.Kind;
            Cursor = request.Cursor;
        }
    }
}