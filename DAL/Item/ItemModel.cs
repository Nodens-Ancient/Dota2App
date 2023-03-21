using Newtonsoft.Json;

namespace Dota2App.Models
{
    public class ItemModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dname")]
        public string? Name { get; set; }

        [JsonProperty("cost")]
        public int? Cost { get; set; }
    }
}
