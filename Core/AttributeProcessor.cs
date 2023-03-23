﻿using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class AttributeProcessor
    {
        public static Hero AddAllStats(ref Hero hero, float AllAttributesBoost)
        {
            AddStrength(ref hero, AllAttributesBoost);
            AddAgility(ref hero, AllAttributesBoost);
            AddAIntellect(ref hero, AllAttributesBoost);

            return hero;
        }

        public static Hero AddStrength(ref Hero hero, float str)
        {
            hero.Strength += str;
            hero.Health += str * AttributeConstants.StrengthHealthBoost;
            hero.HealthRegen += str * AttributeConstants.StrengthHealthRegenBoost;

            if (hero.MainAttribute == BaseAttributes.Strength) hero.Damage += str * AttributeConstants.StrengthDamageBoost;

            return hero;
        }

        public static Hero AddAgility(ref Hero hero, float agility)
        {
            hero.Agility += agility;
            hero.Armor += agility * AttributeConstants.AgilityArmorBoost;
            hero.AttackSpeed += agility * AttributeConstants.AgilityAttackSpedBoost;

            if (hero.MainAttribute == BaseAttributes.Agility) hero.Damage += agility * AttributeConstants.AgilityDamageBoost;

            return hero;
        }

        public static Hero AddAIntellect(ref Hero hero, float intellect)
        {
            hero.Intellect += intellect;
            hero.Mana += intellect * AttributeConstants.IntellectManaBoost;
            hero.ManaRegen +=  intellect * AttributeConstants.IntellectManaRegenBoost;

            if (hero.MainAttribute == BaseAttributes.Intellect) hero.Damage += intellect * AttributeConstants.IntellectDamageBoost;

            return hero;
        }
    }

    public static class AttributeConstants
    {
        public static readonly float StrengthHealthBoost = 20.0f;
        public static readonly float StrengthHealthRegenBoost = 0.1f;
        public static readonly float StrengthDamageBoost = 1f;

        public static readonly float AgilityAttackSpedBoost = 1.0f;
        public static readonly float AgilityArmorBoost = 0.167f;
        public static readonly float AgilityDamageBoost = 1f;

        public static readonly float IntellectManaBoost = 12.0f;
        public static readonly float IntellectManaRegenBoost = 0.05f;
        public static readonly float IntellectDamageBoost = 1f;
    }

    public static class BaseAttributes
    {
        public static readonly string Strength = "str";
        public static readonly string Agility = "agi";
        public static readonly string Intellect = "int";
    }
}
