using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dota2App.DAL.Item
{
    public static class ItemUtils
    {
        
        
    }

    public class ItemAttributeBonusKeys
    {
        public const string BonusDamage = "bonus_damage";
        public const string BonusArmor = "bonus_armor";
        public const string BonusHealthRegen = "bonus_regen";
        public const string BonusAttackSpeed = "bonus_speed";
        public const string BonusManaRegen = "mana_regen";
        public const string BonusMovementSpeed = "movement_speed";
        public const string BonusNightVision = "bonus_night_vision";
        public const string BonusStrength = "bonus_strength";
        public const string BonusAgility = "bonus_agility";
        public const string BonusIntellect = "bonus_intellect";
        public const string BonusAllStats = "bonus_all_stats";
        public const string BonusHealth = "bonus_health";
        public const string BonusMana = "bonus_mana";
        public const string BonusEvasion = "bonus_evasion";
        public const string BonusAttackRange = "base_attack_range";
        public const string BonusMagicResist = "tooltip_resist";
        public const string BonusMovementSpeedPercent = "movement_speed_percent_bonus";
        public const string StatusResistance = "status_resistance";
    }

    public class ItemAttributeJSONConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                return new List<ItemAttributeValue>() { new() { Value = reader.Value.ToString() } };
            }

            JArray array = JArray.Load(reader);
            List<ItemAttributeValue> teams = new List<ItemAttributeValue>();
            foreach (JToken token in array.Children())
            {
                if (token.Type == JTokenType.Object)
                {
                    teams.Add(new() { Value = reader.Value.ToString() });
                }
            }
            return teams;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
