using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Dota2App.DAL.Item
{
    public class ItemAttribute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        [JsonConverter(typeof(ItemAttributeJSONConverter))]
        public List<ItemAttributeValue>? Values { get; set; }

        //[JsonProperty("value", Required = Required.AllowNull)]
        //public string Value { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }
    }
}
