using Newtonsoft.Json;

namespace Livy.Net.LivyModels
{
    public class StatementOutput
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("execution_count")]
        public int ExecutionCount { get; set; }
        
        [JsonProperty("data")]
        public string Data { get; set; }

        public StatementOutput(Models.StatementOutput output)
        {
            Status = output.Status;
            ExecutionCount = output.ExecutionCount;
            Data = output.Data;
        }
    }
}