using Newtonsoft.Json;

namespace Livy.Net.LivyModels
{
    public class Statement
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("code")]
        public string Code { get; set; }
        
        [JsonProperty("state")]
        public StatementState State { get; set; }
        
        [JsonProperty("output")]
        public StatementOutput Output { get; set; }
        
        [JsonProperty("progress")]
        public double Progress { get; set; }
        
        [JsonProperty("started")]
        public long Started { get; set; }
        
        [JsonProperty("completed")]
        public long Completed { get; set; }

        public Statement(Models.Statement statement)
        {
            Id = statement.Id;
            Code = statement.Code;
            State = (StatementState) statement.State;
            Output = new StatementOutput(statement.Output);
            Progress = statement.Progress;
            Started = statement.Started;
            Completed = statement.Completed;
        }

        public Statement()
        {
        }
    }
}