using Newtonsoft.Json;

namespace Dota2App.Models.DTO
{
    public class HeroMatchup
    {
        [JsonProperty("hero_id")] 
        public int HeroId { get; set; }

        [JsonProperty("games_played")]
        public int? GamesPlayed { get; set; }

        [JsonProperty("wins")]
        public int? Wins { get; set; }

        /// <summary>
        /// Api response does not contain hero name,
        /// it could be set from db
        /// </summary>
        [JsonProperty("name")]
        public string? HeroName { get; set; }

        /// <summary>
        /// Api response does not contain winrate,
        /// it could be calculated
        /// </summary>
        [JsonProperty("winrate")]
        public float? Winrate
        {
            get { return (float)Wins / (float)GamesPlayed * 100; }
            set { Winrate = value; }
        }
    }
}
