using System.Collections.Generic;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels
{
    public class Batch
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        [JsonProperty("appInfo")]
        public IDictionary<string, string> AppInfo { get; set; }
        
        [JsonProperty("log")]
        public IEnumerable<string> Log { get; set; }
        
        [JsonProperty("state")]
        public string State { get; set; }

        public Batch(Models.Batch batch)
        {
            Id = batch.Id;
            AppId = batch.AppId;
            AppInfo = batch.AppInfo;
            Log = batch.Log;
            State = batch.State.ToString();
        }

        public Batch()
        {

        }
    }
}