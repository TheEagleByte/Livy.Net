namespace Livy.Net.Models
{
    public class StatementOutput
    {
        public string Status { get; set; }
        public int ExecutionCount { get; set; }
        public string Data { get; set; }

        public StatementOutput(LivyModels.StatementOutput output)
        {
            Status = output.Status;
            ExecutionCount = output.ExecutionCount;
            Data = output.Data;
        }
    }
}