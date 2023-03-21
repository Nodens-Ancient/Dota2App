using Newtonsoft.Json;

namespace Dota2App.Models.DTO
{
    public class HeroPopularItems
    {
        [JsonProperty("start_game_items")]
        public Dictionary<string, int>  StartGameItems{ get; set; }

        [JsonProperty("early_game_items")]
        public Dictionary<string, int> EarlyGameItems { get; set; }

        [JsonProperty("mid_game_items")]
        public Dictionary<string, int> MidGameItems { get; set; }

        [JsonProperty("late_game_items")]
        public Dictionary<string, int> LateGameItems { get; set; }
    }
}
