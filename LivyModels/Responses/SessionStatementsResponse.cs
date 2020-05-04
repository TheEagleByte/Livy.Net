using System.Collections.Generic;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class SessionStatementsResponse
    {
        [JsonProperty("statements")]
        public IEnumerable<Statement> Statements { get; set; }
    }
}