using System.Security.Cryptography.X509Certificates;
using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class ItemStatsProcessor
    {
        public void AddBonusDamage(ref Hero hero, float bonusDamage)
        {
            hero.Damage += bonusDamage;
        }

        public void AddBonusHealth(ref Hero hero, float health)
        {
            hero.Health += health;
        }

        public void AddBonusHealthRegen(ref Hero hero, float healthRegen)
        {
            hero.HealthRegen += healthRegen;
        }

        public void AddBonusMana(ref Hero hero, float mana)
        {
            hero.Mana += mana;
        }

        public void AddBonusManaRegen(ref Hero hero, float manaRegen)
        {
            hero.ManaRegen += manaRegen;
        }

        public void AddBonusArmor(ref Hero hero, float armor)
        {
            hero.Armor += armor;//TODO calculate according to mechanics
        }

        public void AddBonusMagicResistance(ref Hero hero, float magicResistance)
        {
            hero.MagicResist += magicResistance;//TODO calculate according to mechanics
        }

        public void AddBonusEvasion(ref Hero hero, float evasion)
        {
            hero.Evasion += evasion;//TODO calculate according to mechanics
        }

        public void AddBonusNightVision(ref Hero hero, float nightVision)
        {
            hero.NightVision += nightVision;
        }

        public void AddAllStats(ref Hero hero, float AllStats)
        {
            AttributeProcessor.AddAllStats(ref hero, AllStats);
        }

        public void AddStrength(ref Hero hero, float strength)
        {
            AttributeProcessor.AddStrength(ref hero, strength);
        }

        public void AddAgility(ref Hero hero, float agility)
        {
            AttributeProcessor.AddAgility(ref hero, agility);
        }

        public void AddIntellect(ref Hero hero, float intellect)
        {
            AttributeProcessor.AddAIntellect(ref hero, intellect);
        }
    }
}
