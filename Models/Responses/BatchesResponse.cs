using System.Collections.Generic;
using System.Linq;

namespace Livy.Net.Models.Responses
{
    public class BatchesResponse
    {
        /// <summary>
        /// The start index of fetched sessions
        /// </summary>
        public int From { get; set; }

        /// <summary>
        /// Number of sessions fetched
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Batch List
        /// </summary>
        public IEnumerable<Batch> Sessions { get; set; }

        public BatchesResponse(LivyModels.Responses.BatchesResponse response)
        {
            From = response.From;
            Total = response.Total;
            Sessions = response.Sessions.Select(x => new Batch(x));
        }
    }
}