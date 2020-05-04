using System;
using System.Collections.Generic;

namespace Livy.Net.Models
{
    public class Batch
    {
        /// <summary>
        /// The session id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The application id of this session
        /// </summary>
        public string AppId { get; set; }
        
        /// <summary>
        /// The detailed application info
        /// </summary>
        public IDictionary<string, string> AppInfo { get; set; }
        
        /// <summary>
        /// The log lines
        /// </summary>
        public IEnumerable<string> Log { get; set; }
        
        /// <summary>
        /// The batch state
        /// </summary>
        public SessionState State { get; set; }

        public Batch(LivyModels.Batch batch)
        {
            Id = batch.Id;
            AppId = batch.AppId;
            AppInfo = batch.AppInfo;
            Log = batch.Log;
            State = (SessionState)Enum.Parse(typeof(SessionState), batch.State, true);
        }
    }
}