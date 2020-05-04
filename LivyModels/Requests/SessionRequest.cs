using System.Collections.Generic;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Requests
{
    public class SessionRequest
    {
        [JsonProperty("kind")]
        public SessionKind Kind { get; set; }
        
        [JsonProperty("proxyUser")]
        public string ProxyUser { get; set; }
        
        [JsonProperty("jars")]
        public IEnumerable<string> Jars { get; set; }
        
        [JsonProperty("pyFiles")]
        public IEnumerable<string> PyFiles { get; set; }
        
        [JsonProperty("files")]
        public IEnumerable<string> Files { get; set; }
        
        [JsonProperty("driverMemory")]
        public string DriverMemory { get; set; }
        
        [JsonProperty("driverCores")]
        public int? DriverCores { get; set; }
        
        [JsonProperty("executorMemory")]
        public string ExecutorMemory { get; set; }
        
        [JsonProperty("executorCores")]
        public int? ExecutorCores { get; set; }
        
        [JsonProperty("numExecutors")]
        public int? NumOfExecutors { get; set; }
        
        [JsonProperty("archives")]
        public IEnumerable<string> Archives { get; set; }
        
        [JsonProperty("queue")]
        public string Queue { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("conf")]
        public IDictionary<string, string> Conf { get; set; }
        
        [JsonProperty("heartbeatTimeoutInSecond")]
        public int? HeartbeatTimeoutInSecond { get; set; }
        public SessionRequest(Models.Requests.SessionRequest request)
        {
            Kind = (SessionKind) request.Kind;
            ProxyUser = request.ProxyUser;
            Jars = request.Jars;
            PyFiles = request.PyFiles;
            Files = request.Files;
            DriverMemory = request.DriverMemory;
            DriverCores = request.DriverCores;
            ExecutorMemory = request.ExecutorMemory;
            ExecutorCores = request.ExecutorCores;
            NumOfExecutors = request.NumOfExecutors;
            Archives = request.Archives;
            Queue = request.Queue;
            Name = request.Name;
            Conf = request.Conf;
            HeartbeatTimeoutInSecond = request.HeartbeatTimeoutInSecond;
        }

    }
}