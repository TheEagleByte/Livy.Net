using System.Collections.Generic;

namespace Livy.Net.Models.Responses
{
    public class SessionLogResponse
    {
        /// <summary>
        /// The session Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Offset from the start of the log
        /// </summary>
        public int From { get; set; }
        
        /// <summary>
        /// Max number of log lines
        /// </summary>
        public int Size { get; set; }
        
        /// <summary>
        /// The log lines
        /// </summary>
        public IEnumerable<string> Log { get; set; }

        public SessionLogResponse(LivyModels.Responses.SessionLogResponse response)
        {
            Id = response.Id;
            From = response.From;
            Size = response.Size;
            Log = response.Log;
        }
    }
}