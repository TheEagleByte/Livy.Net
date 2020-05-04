using System.Collections.Generic;

namespace Livy.Net.Models.Requests
{
    public class BatchRequest
    {
        /// <summary>
        /// File containing the application to execute
        /// </summary>
        public string File { get; set; }
        
        /// <summary>
        /// User to impersonate when running the job
        /// </summary>
        public string ProxyUser { get; set; }
        
        /// <summary>
        /// Application Java/Spark main class
        /// </summary>
        public string ClassName { get; set; }
        
        /// <summary>
        /// Command line arguments for the application
        /// </summary>
        public IEnumerable<string> Arguments { get; set; }
        
        /// <summary>
        /// jars to be used in this session
        /// </summary>
        public IEnumerable<string> Jars { get; set; }
        
        /// <summary>
        /// Python files to be used in this session
        /// </summary>
        public IEnumerable<string> PyFiles { get; set; }
        
        /// <summary>
        /// files to be used in this session
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
        /// Archives to be used in this session
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

        public BatchRequest()
        {

        }

        public BatchRequest(LivyModels.Requests.BatchRequest request)
        {
            File = request.File;
            ProxyUser = request.ProxyUser;
            ClassName = request.ClassName;
            Arguments = request.Arguments;
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
        }
    }
}