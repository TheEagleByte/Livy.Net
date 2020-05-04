namespace Livy.Net.Models
{
    public enum SessionState
    {
        /// <summary>
        /// Session has not been started
        /// </summary>
        NotStarted,
        
        /// <summary>
        /// Session is starting
        /// </summary>
        Starting,
        
        /// <summary>
        /// Session is waiting for input
        /// </summary>
        Idle,
        
        /// <summary>
        /// Session is executing a statement
        /// </summary>
        Busy,

        /// <summary>
        /// Session is running
        /// </summary>
        Running,
        
        /// <summary>
        /// Session is shutting down
        /// </summary>
        ShuttingDown,
        
        /// <summary>
        /// Session errored out
        /// </summary>
        Error,
        
        /// <summary>
        /// Session has exited
        /// </summary>
        Dead,
        
        /// <summary>
        /// Session has been killed
        /// </summary>
        Killed,
        
        /// <summary>
        /// Session is successfully stopped
        /// </summary>
        Success
    }
}