using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Livy.Net.LivyModels
{
    public enum SessionState
    {
        [JsonProperty("not_started")]
        [JsonConverter(typeof(StringEnumConverter))]
        NotStarted,
        
        [JsonProperty("starting")]
        [JsonConverter(typeof(StringEnumConverter))]
        Starting,
        
        [JsonProperty("idle")]
        [JsonConverter(typeof(StringEnumConverter))]
        Idle,
        
        [JsonProperty("busy")]
        [JsonConverter(typeof(StringEnumConverter))]
        Busy,
        
        [JsonProperty("shutting_down")]
        [JsonConverter(typeof(StringEnumConverter))]
        ShuttingDown,
        
        [JsonProperty("error")]
        [JsonConverter(typeof(StringEnumConverter))]
        Error,
        
        [JsonProperty("dead")]
        [JsonConverter(typeof(StringEnumConverter))]
        Dead,
        
        [JsonProperty("killed")]
        [JsonConverter(typeof(StringEnumConverter))]
        Killed,
        
        [JsonProperty("success")]
        [JsonConverter(typeof(StringEnumConverter))]
        Success
    }
}