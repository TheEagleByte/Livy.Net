namespace Livy.Net.Models.Requests
{
    public class SessionCompletionRequest
    {
        /// <summary>
        /// The code for which completion proposals are requested
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The kind of code to execute
        /// </summary>
        public SessionKind Kind { get; set; }

        /// <summary>
        /// Cursor position to get proposals
        /// </summary>
        public string Cursor { get; set; }

        public SessionCompletionRequest(LivyModels.Requests.SessionCompletionRequest request)
        {
            Code = request.Code;
            Kind = (SessionKind) request.Kind;
            Cursor = request.Cursor;
        }
    }
}