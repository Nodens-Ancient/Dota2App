using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class AttributeProcessor
    {
        public static Hero AddAllStats(ref Hero hero, float AllAttributesBoost)
        {
            AddStrength(ref hero, AllAttributesBoost);
            AddAgility(ref hero, AllAttributesBoost);
            AddIntellect(ref hero, AllAttributesBoost);

            return hero;
        }

        public static Hero AddStrength(ref Hero hero, float str)
        {
            hero.AddStrength((float)Math.Round(str, MidpointRounding.AwayFromZero));
            hero.AddHealth((int)(str) * AttributeConstants.StrengthHealthBoost);
            hero.AddHealthRegen(str * AttributeConstants.StrengthHealthRegenBoost);

            if (hero.MainAttribute == BaseAttributes.Strength)
                hero.AddDamage((float)Math.Round(str * AttributeConstants.StrengthDamageBoost, MidpointRounding.AwayFromZero));

            return hero;
        }

        public static Hero AddAgility(ref Hero hero, float agility)
        {
            hero.AddAgility((float)Math.Round(agility, MidpointRounding.AwayFromZero));
            hero.AddArmor(agility * AttributeConstants.AgilityArmorBoost);
            hero.AttackSpeed += agility * AttributeConstants.AgilityAttackSpedBoost;

            if (hero.MainAttribute == BaseAttributes.Agility)
                hero.AddDamage((float)Math.Round(agility * AttributeConstants.AgilityDamageBoost, MidpointRounding.AwayFromZero));

            return hero;
        }

        public static Hero AddIntellect(ref Hero hero, float intellect)
        {
            hero.AddIntellect((float)Math.Round(intellect, MidpointRounding.AwayFromZero));
            hero.AddMana((int)intellect * AttributeConstants.IntellectManaBoost);
            hero.AddManaRegen(intellect * AttributeConstants.IntellectManaRegenBoost);

            if (hero.MainAttribute == BaseAttributes.Intellect)
                hero.AddDamage((float)Math.Round(intellect * AttributeConstants.IntellectDamageBoost, MidpointRounding.AwayFromZero));

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
