namespace Livy.Net.Models.Responses
{
    public class SessionStatementCancelResponse
    {
        /// <summary>
        /// Is always "canceled"
        /// </summary>
        public string Message { get; set; }

        public SessionStatementCancelResponse(LivyModels.Responses.SessionStatementCancelResponse response)
        {
            Message = response.Message;
        }
    }
}