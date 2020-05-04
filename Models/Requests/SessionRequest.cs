using System.Collections.Generic;

namespace Livy.Net.Models.Requests
{
    public class SessionRequest
    {
        /// <summary>
        /// The session kind
        /// </summary>
        public SessionKind Kind { get; set; }
        
        /// <summary>
        /// User to impersonate when starting the session
        /// </summary>
        public string ProxyUser { get; set; }
        
        /// <summary>
        /// jars to be used in this session
        /// </summary>
        public IEnumerable<string> Jars { get; set; }
        
        /// <summary>
        /// Python files to be used in this session
        /// </summary>
        public IEnumerable<string> PyFiles { get; set; }
        
        /// <summary>
        /// Files to be used in this session
        /// </summary>
        public IEnumerable<string> Files { get; set; }
        
        /// <summary>
        /// Amount of memory to use for the driver process
        /// </summary>
        public string DriverMemory { get; set; }
        
        /// <summary>
        /// Number of cores to use for the driver process
        /// </summary>
        public int? DriverCores { get; set; }
        
        /// <summary>
        /// Amount of memory to use per executor process
        /// </summary>
        public string ExecutorMemory { get; set; }
        
        /// <summary>
        /// Number of cores to use for each executor
        /// </summary>
        public int? ExecutorCores { get; set; }
        
        /// <summary>
        /// Number of executors to launch for this session
        /// </summary>
        public int? NumOfExecutors { get; set; }
        
        /// <summary>
        /// Archives to be used for this session
        /// </summary>
        public IEnumerable<string> Archives { get; set; }
        
        /// <summary>
        /// The name of the YARN queue to which submitted
        /// </summary>
        public string Queue { get; set; }
        
        /// <summary>
        /// The name of this session
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Spark configuration properties
        /// </summary>
        public IDictionary<string, string> Conf { get; set; }
        
        /// <summary>
        /// Timeout in seconds to which session will be orphaned
        /// </summary>
        public int? HeartbeatTimeoutInSecond { get; set; }

        public SessionRequest(LivyModels.Requests.SessionRequest request)
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