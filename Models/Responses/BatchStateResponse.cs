namespace Livy.Net.Models.Responses
{
    public class BatchStateResponse
    {
        /// <summary>
        /// Batch Session Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The current state of the batch session
        /// </summary>
        public string State { get; set; }

        public BatchStateResponse(LivyModels.Responses.BatchStateResponse response)
        {
            Id = response.Id;
            State = response.State;
        }
    }
}