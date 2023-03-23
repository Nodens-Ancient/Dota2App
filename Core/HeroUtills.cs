using Dota2App.Models;
using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class HeroUtills
    {
        public static Hero HeroModelToHeroMap(HeroModel hModel)
        {
            var hero = new Hero()
            {
                Id = hModel.Id,
                Name = hModel.Name,
                Level = 1,
                MainAttribute = hModel.MainAttribute,

                MagicResist = hModel.BaseMagicResist,
                StrengthGain = hModel.StrengthGain,
                AgilityGain = hModel.AgilityGain,
                IntellectGain = hModel.IntellectGain,

                Health = hModel.BaseHealth,
                Mana = hModel.BaseMana,
                HealthRegen = hModel.BaseHealthRegen,
                ManaRegen = hModel.BaseManaRegen,
                Armor = hModel.BaseArmor,
                Damage = (hModel.BaseAttackDamageMax + hModel.BaseAttackDamageMin) / 2.0f
            };

            AttributeProcessor.AddStrength(ref hero, hModel.BaseStrength);
            AttributeProcessor.AddAgility(ref hero, hModel.BaseAgility);
            AttributeProcessor.AddAIntellect(ref hero, hModel.BaseIntellect);
            
            return hero;
        }
    }
}
