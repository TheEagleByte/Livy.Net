using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Requests
{
    public class SessionStatementRequest
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        
        [JsonProperty("kind")]
        public SessionKind Kind { get; set; }

        public SessionStatementRequest(Models.Requests.SessionStatementRequest request)
        {
            Code = request.Code;
            Kind = (SessionKind) request.Kind;
        }
    }
}