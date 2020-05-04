namespace Livy.Net.Models.Responses
{
    public class SessionStateResponse
    {
        /// <summary>
        /// The session Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The current state of the session
        /// </summary>
        public SessionState State { get; set; }

        public SessionStateResponse(LivyModels.Responses.SessionStateResponse response)
        {
            Id = response.Id;
            State = (SessionState)response.State;
        }
    }
}