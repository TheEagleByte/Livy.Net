using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Livy.Net.LivyModels
{
    public enum SessionKind
    {
        [JsonProperty("spark")]
        [JsonConverter(typeof(StringEnumConverter))]
        Spark,

        [JsonProperty("pyspark")]
        [JsonConverter(typeof(StringEnumConverter))]
        PySpark,

        [JsonProperty("sparkr")]
        [JsonConverter(typeof(StringEnumConverter))]
        SparkR,

        [JsonProperty("sql")]
        [JsonConverter(typeof(StringEnumConverter))]
        Sql
    }
}