using System.Collections.Generic;

namespace Livy.Net.Models
{
    public class Session
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
        /// The remote user who submitted this session
        /// </summary>
        public string Owner { get; set; }
        
        /// <summary>
        /// User to impersonate when running
        /// </summary>
        public string ProxyUser { get; set; }
        
        /// <summary>
        /// Session kind
        /// </summary>
        public SessionKind Kind { get; set; }
        
        /// <summary>
        /// The log lines
        /// </summary>
        public IEnumerable<string> Log { get; set; }
        
        /// <summary>
        /// The session state
        /// </summary>
        public SessionState State { get; set; }
        
        /// <summary>
        /// The detailed application info
        /// </summary>
        public IDictionary<string, string> AppInfo { get; set; }

        public Session(LivyModels.Session session)
        {
            Id = session.Id;
            AppId = session.AppId;
            Owner = session.Owner;
            ProxyUser = session.ProxyUser;
            Kind = (SessionKind) session.Kind;
            Log = session.Log;
            State = (SessionState) session.State;
            AppInfo = session.AppInfo;
        }
    }
}