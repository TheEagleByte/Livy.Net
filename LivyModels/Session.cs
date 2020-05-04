using System.Collections.Generic;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels
{
    public class Session
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        [JsonProperty("owner")]
        public string Owner { get; set; }
        
        [JsonProperty("proxyUser")]
        public string ProxyUser { get; set; }
        
        [JsonProperty("kind")]
        public SessionKind Kind { get; set; }
        
        [JsonProperty("log")]
        public IEnumerable<string> Log { get; set; }
        
        [JsonProperty("state")]
        public SessionState State { get; set; }
        
        [JsonProperty("appInfo")]
        public IDictionary<string, string> AppInfo { get; set; }
        public Session(Models.Session session)
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

        public Session()
        {
        }
    }
}