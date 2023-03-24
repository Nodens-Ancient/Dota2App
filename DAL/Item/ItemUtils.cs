﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dota2App.DAL.Item
{
    public static class ItemUtils
    {
        
        
    }

    public static class ItemAttributeBonusKeys
    {
        public static readonly string BonusDamage = "bonus_damage";
        public static readonly string BonusArmor = "bonus_armor";
        public static readonly string BonusHealthRegen = "bonus_regen";
        public static readonly string BonusAttackSpeed = "bonus_speed";
        public static readonly string BonusManaRegen = "mana_regen";
        public static readonly string BonusMovementSpeed = "movement_speed";
        public static readonly string BonusNightVision = "bonus_night_vision";
        public static readonly string BonusStrength = "bonus_strength";
        public static readonly string BonusAgility = "bonus_agility";
        public static readonly string BonusIntellect = "bonus_intellect";
        public static readonly string BonusAllStats = "bonus_all_stats";
        public static readonly string BonusHealth = "bonus_health";
        public static readonly string BonusMana = "bonus_mana";
        public static readonly string BonusEvasion = "bonus_evasion";
        public static readonly string BonusAttackRange = "base_attack_range";
        public static readonly string BonusMagicResist = "tooltip_resist";
        public static readonly string BonusMovementSpeedPercent = "movement_speed_percent_bonus";
        public static readonly string StatusResistance = "status_resistance";
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
