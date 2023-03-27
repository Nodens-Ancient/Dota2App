using Dota2App.DAL.Item;
using Dota2App.Models;
using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class ItemStatsProcessor
    {
        public static void AddHeroItems(ref Hero hero, List<ItemModel> items)
        {
            var tHero = hero;
            items.ForEach(item =>
            {
                item.AttributeBonuses.ForEach(itemBonus =>
                {
                    //var bonusValue = float.Parse(itemBonus.Values.First().Value);

                    switch (itemBonus.Key)
                    {
                        //case ItemAttributeBonusKeys.BonusDamage:
                        //    tHero.AddDamage(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusHealth:
                        //    tHero.AddHealth(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusAgility:
                        //    AttributeProcessor.AddAgility(ref tHero, bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusArmor:
                        //    tHero.AddArmor(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusEvasion:
                        //    tHero.AddEvasion(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusIntellect:
                        //    AttributeProcessor.AddIntellect(ref tHero, bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusStrength:
                        //    AttributeProcessor.AddStrength(ref tHero, bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusMana:
                        //    tHero.AddMana(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusAttackSpeed:
                        //    tHero.AddAttackSpeed(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusAllStats:
                        //    AttributeProcessor.AddAllStats(ref tHero, bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusHealthRegen:
                        //    tHero.AddHealthRegen(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusManaRegen:
                        //    tHero.AddManaRegen(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusMagicResist:
                        //    tHero.AddMagicResist(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusNightVision:
                        //    tHero.AddNightVision(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusAttackRange:
                        //    tHero.AddAttackRange(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusMovementSpeed:
                        //    tHero.AddMoveSpeed(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.BonusMovementSpeedPercent:
                        //    tHero.AddMoveSpeedPercent(bonusValue);
                        //    break;
                        //case ItemAttributeBonusKeys.StatusResistance:
                        //    tHero.AddStatusResistance(bonusValue);
                        //    break;
                        default:
                            break;
                    }
                });
            });
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
            AttributeProcessor.AddIntellect(ref hero, intellect);
        }
    }
}
