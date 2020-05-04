using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Livy.Net.LivyModels
{
    public enum StatementState
    {
        [JsonProperty("waiting")]
        [JsonConverter(typeof(StringEnumConverter))]
        Waiting,
        
        [JsonProperty("running")]
        [JsonConverter(typeof(StringEnumConverter))]
        Running,
        
        [JsonProperty("available")]
        [JsonConverter(typeof(StringEnumConverter))]
        Available,
        
        [JsonProperty("error")]
        [JsonConverter(typeof(StringEnumConverter))]
        Error,
        
        [JsonProperty("cancelling")]
        [JsonConverter(typeof(StringEnumConverter))]
        Cancelling,
        
        [JsonProperty("cancelled")]
        [JsonConverter(typeof(StringEnumConverter))]
        Cancelled
    }
}