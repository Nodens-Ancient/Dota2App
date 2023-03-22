using Newtonsoft.Json;

namespace Dota2App.Models
{
    public class HeroModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("localized_name")]
        public string Name { get; set; }

        [JsonProperty("primary_attr")]
        public string MainAttribute { get; set; }

        [JsonProperty("move_speed")]
        public int MoveSpeed { get; set; }

        [JsonProperty("base_health")]
        public int BaseHealth { get; set; }

        [JsonProperty("base_health_regen")]
        public float BaseHealthRegen { get; set; }

        [JsonProperty("base_mana")]
        public int BaseMana { get; set; }

        [JsonProperty("base_mana_regen")]
        public float BaseManaRegen { get; set; }

        [JsonProperty("base_armor")]
        public float BaseArmor { get; set; }

        [JsonProperty("base_mr")]
        public int BaseMagicResist { get; set; }

        [JsonProperty("base_attack_min")]
        public int BaseAttackDamageMin { get; set; }

        [JsonProperty("base_attack_max")]
        public int BaseAttackDamageMax { get; set; }

        [JsonProperty("base_str")]
        public int BaseStrength { get; set; }

        [JsonProperty("base_agi")]
        public int BaseAgility { get; set; }

        [JsonProperty("base_int")]
        public int BaseIntellect { get; set; }

        [JsonProperty("str_gain")]
        public float StrengthGain { get; set; }

        [JsonProperty("agi_gain")]
        public float AgilityGain { get; set; }

        [JsonProperty("int_gain")]
        public float IntellectGain { get; set; }

        [JsonProperty("attack_range")]
        public int AttackRange { get; set; }

        [JsonProperty("projectile_speed")]
        public int ProjectileSpeed { get; set; }

        [JsonProperty("attack_rate")]
        public float AttackSpeed { get; set; }

        [JsonProperty("day_vision")] 
        public float DayVision { get; set; }

        [JsonProperty("night_vision")]
        public float NightVision { get; set; }
    }
}
