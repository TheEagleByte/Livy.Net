namespace Livy.Net.Models
{
    public class Statement
    {
        /// <summary>
        /// The statement id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The execution code
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// The execution state
        /// </summary>
        public StatementState State { get; set; }
        
        /// <summary>
        /// The execution output
        /// </summary>
        public StatementOutput Output { get; set; }
        
        /// <summary>
        /// The execution progress
        /// </summary>
        public double Progress { get; set; }
        
        /// <summary>
        /// The start time of statement code
        /// </summary>
        public long Started { get; set; }
        
        /// <summary>
        /// The complete time of statement code
        /// </summary>
        public long Completed { get; set; }
        
        public Statement(LivyModels.Statement statement)
        {
            Id = statement.Id;
            Code = statement.Code;
            State = (StatementState) statement.State;
            Output = new StatementOutput(statement.Output);
            Progress = statement.Progress;
            Started = statement.Started;
            Completed = statement.Completed;
        }
    }
}