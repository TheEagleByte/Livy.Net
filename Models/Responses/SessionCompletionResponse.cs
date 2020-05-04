using System.Collections.Generic;

namespace Livy.Net.Models.Responses
{
    public class SessionCompletionResponse
    {
        /// <summary>
        /// Code completions proposals
        /// </summary>
        public IEnumerable<string> Candidates { get; set; }

        public SessionCompletionResponse(LivyModels.Responses.SessionCompletionResponse response)
        {
            Candidates = response.Candidates;
        }
    }
}