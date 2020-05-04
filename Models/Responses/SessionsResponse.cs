using System.Collections.Generic;
using System.Linq;

namespace Livy.Net.Models.Responses
{
    public class SessionsResponse
    {
        /// <summary>
        /// The start index to fetch sessions
        /// </summary>
        public int From { get; set; }

        /// <summary>
        /// Number of sessions to fetch
        /// </summary>
        public int Total { get; set; }
        
        /// <summary>
        /// List of sessions
        /// </summary>
        public IEnumerable<Session> Sessions { get; set; }

        public SessionsResponse(LivyModels.Responses.SessionsResponse response)
        {
            From = response.From;
            Total = response.Total;
            Sessions = response.Sessions.Select(x => new Session(x));
        }
    }
}