using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livy.Net.Interfaces;
using Livy.Net.LivyModels.Responses;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;

namespace Livy.Net
{
    public class LivyClient : ILivyClient
    {
        private readonly LivyClientConfiguration _config;
        private readonly IRestClient _client;

        public LivyClient(LivyClientConfiguration config)
        {
            _config = config;
            _client = new RestClient(config.BaseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(config.Username, config.Password)
            };
            
            _client.UseNewtonsoftJson();
        }

        public async Task<Models.Responses.SessionsResponse> GetSessions(int @from, int size)
        {
            var request = new RestRequest("sessions").AddDefaultHeader(_config.Username);
            request.AddParameter("from", from);
            request.AddParameter("size", size);
            var response = await _client.GetAsync<SessionsResponse>(request);
            return new Models.Responses.SessionsResponse(response);
        }

        public async Task<Models.Session> CreateSession(Models.Requests.SessionRequest session)
        {
            var request = new RestRequest("sessions", Method.POST).AddDefaultHeader(_config.Username);
            request.AddJsonBody(new LivyModels.Requests.SessionRequest(session));
            var response = await _client.ExecutePostAsync<LivyModels.Session>(request);
            return new Models.Session(response.Data);
        }

        public async Task<Models.Session> GetSession(int sessionId)
        {
            var request = new RestRequest($"sessions/{sessionId}").AddDefaultHeader(_config.Username);
            var response = await _client.GetAsync<LivyModels.Session>(request);
            return new Models.Session(response);
        }

        public async Task<Models.Responses.SessionStateResponse> GetSessionState(int sessionId)
        {
            var request = new RestRequest($"sessions/{sessionId}/state").AddDefaultHeader(_config.Username);
            var response = await _client.GetAsync<SessionStateResponse>(request);
            return new Models.Responses.SessionStateResponse(response);
        }

        public async Task KillSession(int sessionId)
        {
            var request = new RestRequest($"sessions/{sessionId}").AddDefaultHeader(_config.Username);
            await _client.DeleteAsync<object>(request);
        }

        public async Task<Models.Responses.SessionLogResponse> GetSessionLogs(int sessionId, int @from, int size)
        {
            var request = new RestRequest($"sessions/{sessionId}/log").AddDefaultHeader(_config.Username);
            request.AddParameter("from", from);
            request.AddParameter("size", size);
            var response = await _client.GetAsync<SessionLogResponse>(request);
            return new Models.Responses.SessionLogResponse(response);
        }

        public async Task<IEnumerable<Models.Statement>> GetSessionStatements(int sessionId)
        {
            var request = new RestRequest($"sessions/{sessionId}/statements").AddDefaultHeader(_config.Username);
            var response = await _client.GetAsync<SessionStatementsResponse>(request);
            return response.Statements.Select(x => new Models.Statement(x));
        }

        public async Task<Models.Statement> RunStatement(int sessionId, Models.Requests.SessionStatementRequest statement)
        {
            var request = new RestRequest($"sessions/{sessionId}/statements", Method.POST).AddDefaultHeader(_config.Username);
            request.AddJsonBody(new LivyModels.Requests.SessionStatementRequest(statement));
            var response = await _client.ExecutePostAsync<LivyModels.Statement>(request);
            return new Models.Statement(response.Data);
        }

        public async Task<Models.Statement> GetStatement(int sessionId, int statementId)
        {
            var request = new RestRequest($"sessions/{sessionId}/statements/{statementId}").AddDefaultHeader(_config.Username);
            var response = await _client.GetAsync<LivyModels.Statement>(request);
            return new Models.Statement(response);
        }

        public async Task<Models.Responses.SessionStatementCancelResponse> CancelStatement(int sessionId, int statementId)
        {
            var request = new RestRequest($"sessions/{sessionId}/statements/{statementId}/cancel", Method.POST).AddDefaultHeader(_config.Username);
            var response = await _client.ExecutePostAsync<SessionStatementCancelResponse>(request);
            return new Models.Responses.SessionStatementCancelResponse(response.Data);
        }

        public async Task<Models.Responses.SessionCompletionResponse> RunStatementCompletion(int sessionId, Models.Requests.SessionCompletionRequest statement)
        {
            var request = new RestRequest($"sessions/{sessionId}/completion", Method.POST).AddDefaultHeader(_config.Username);
            request.AddJsonBody(new LivyModels.Requests.SessionCompletionRequest(statement));
            var response = await _client.ExecutePostAsync<SessionCompletionResponse>(request);
            return new Models.Responses.SessionCompletionResponse(response.Data);
        }

        public async Task<Models.Responses.BatchesResponse> GetBatches(int @from, int size)
        {
            var request = new RestRequest("batches").AddDefaultHeader(_config.Username);
            request.AddParameter("from", from);
            request.AddParameter("size", size);
            var response = await _client.GetAsync<BatchesResponse>(request);
            return new Models.Responses.BatchesResponse(response);
        }

        public async Task<Models.Batch> CreateBatch(Models.Requests.BatchRequest batch)
        {
            var request = new RestRequest("batches", Method.POST).AddDefaultHeader(_config.Username);
            request.AddJsonBody(new LivyModels.Requests.BatchRequest(batch));
            var response = await _client.ExecutePostAsync<LivyModels.Batch>(request);
            return new Models.Batch(response.Data);
        }

        public async Task<Models.Batch> GetBatch(int batchId)
        {
            var request = new RestRequest($"batches/{batchId}").AddDefaultHeader(_config.Username);
            var response = await _client.GetAsync<LivyModels.Batch>(request);
            return new Models.Batch(response);
        }

        public async Task<Models.Responses.BatchStateResponse> GetBatchState(int batchId)
        {
            var request = new RestRequest($"batches/{batchId}/state").AddDefaultHeader(_config.Username);
            var response = await _client.GetAsync<BatchStateResponse>(request);
            return new Models.Responses.BatchStateResponse(response);
        }

        public async Task KillBatch(int batchId)
        {
            var request = new RestRequest($"batches/{batchId}").AddDefaultHeader(_config.Username);
            await _client.DeleteAsync<object>(request);
        }

        public async Task<Models.Responses.BatchLogResponse> GetBatchLogs(int batchId, int @from, int size)
        {
            var request = new RestRequest($"batches/{batchId}/log").AddDefaultHeader(_config.Username);
            request.AddParameter("from", from);
            request.AddParameter("size", size);
            var response = await _client.GetAsync<BatchLogResponse>(request);
            return new Models.Responses.BatchLogResponse(response);
        }
    }
}