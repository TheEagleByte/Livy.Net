using System.Collections.Generic;
using System.Threading.Tasks;
using Livy.Net.Models;
using Livy.Net.Models.Requests;
using Livy.Net.Models.Responses;

namespace Livy.Net.Interfaces
{
    public interface ILivyClient
    {
        /// <summary>
        /// Gets a list of sessions
        /// </summary>
        /// <param name="from">The start index to fetch sessions</param>
        /// <param name="size">Number of sessions to fetch</param>
        /// <returns>All the active interactive sessions</returns>
        Task<SessionsResponse> GetSessions(int from, int size);
        
        /// <summary>
        /// Creates a new interactive Scala, Python, or R shell in the cluster.
        /// </summary>
        /// <param name="session">The session to create</param>
        /// <returns>The created session</returns>
        Task<Session> CreateSession(SessionRequest session);

        /// <summary>
        /// Gets the session information
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <returns>The session information</returns>
        Task<Session> GetSession(int sessionId);

        /// <summary>
        /// Gets the state of a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <returns>The state of the session</returns>
        Task<SessionStateResponse> GetSessionState(int sessionId);

        /// <summary>
        /// Kills the session job
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <returns>Nothing</returns>
        Task KillSession(int sessionId);

        /// <summary>
        /// Gets the log lines from a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <param name="from">Offset</param>
        /// <param name="size">Max number of log lines to return</param>
        /// <returns>The log lines</returns>
        Task<SessionLogResponse> GetSessionLogs(int sessionId, int from, int size);

        /// <summary>
        /// Gets all the statements in a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <returns>All statements in a session</returns>
        Task<IEnumerable<Statement>> GetSessionStatements(int sessionId);

        /// <summary>
        /// Runs a statement in a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <param name="statement">The statement to execute</param>
        /// <returns>The statement that was executed</returns>
        Task<Statement> RunStatement(int sessionId, SessionStatementRequest statement);

        /// <summary>
        /// Gets a specific statement in a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <param name="statementId">Statement Id</param>
        /// <returns>A specific statement in a session</returns>
        Task<Statement> GetStatement(int sessionId, int statementId);

        /// <summary>
        /// Cancels the specified statement in a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <param name="statementId">Statement Id to cancel</param>
        /// <returns>A message</returns>
        Task<SessionStatementCancelResponse> CancelStatement(int sessionId, int statementId);

        /// <summary>
        /// Runs a statement in a session
        /// </summary>
        /// <param name="sessionId">Session Id</param>
        /// <param name="statement">The statement to run</param>
        /// <returns>The completion proposals</returns>
        Task<SessionCompletionResponse> RunStatementCompletion(int sessionId, SessionCompletionRequest statement);

        /// <summary>
        /// Gets all the active batch sessions
        /// </summary>
        /// <param name="from">The start index to fetch sessions</param>
        /// <param name="size">Number of sessions to fetch</param>
        /// <returns>The batch list</returns>
        Task<BatchesResponse> GetBatches(int from, int size);

        /// <summary>
        /// Creates a new batch
        /// </summary>
        /// <param name="batch">The batch to create</param>
        /// <returns>The created batch</returns>
        Task<Batch> CreateBatch(BatchRequest batch);

        /// <summary>
        /// Gets the batch session information
        /// </summary>
        /// <param name="batchId">Batch Id</param>
        /// <returns>The Batch</returns>
        Task<Batch> GetBatch(int batchId);

        /// <summary>
        /// Gets the state of the batch session
        /// </summary>
        /// <param name="batchId">Batch Id</param>
        /// <returns>The state of the batch session</returns>
        Task<BatchStateResponse> GetBatchState(int batchId);

        /// <summary>
        /// Kills the batch job
        /// </summary>
        /// <param name="batchId">Batch Id</param>
        /// <returns>Nothing</returns>
        Task KillBatch(int batchId);

        /// <summary>
        /// Gets the log lines from a batch
        /// </summary>
        /// <param name="batchId">Batch Id</param>
        /// <param name="from">Offset</param>
        /// <param name="size">Max number of log lines to return</param>
        /// <returns>The logs for the batch</returns>
        Task<BatchLogResponse> GetBatchLogs(int batchId, int from, int size);
    }
}