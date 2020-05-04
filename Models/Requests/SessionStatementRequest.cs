namespace Livy.Net.Models.Requests
{
    public class SessionStatementRequest
    {
        /// <summary>
        /// The code to execute
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// The kind of code to execute
        /// </summary>
        public SessionKind Kind { get; set; }

        public SessionStatementRequest(LivyModels.Requests.SessionStatementRequest request)
        {
            Code = request.Code;
            Kind = (SessionKind) request.Kind;
        }
    }
}