using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class SessionStatementCancelResponse
    {
        [JsonProperty("msg")]
        public string Message { get; set; }

        public SessionStatementCancelResponse(Models.Responses.SessionStatementCancelResponse response)
        {
            Message = response.Message;
        }
    }
}