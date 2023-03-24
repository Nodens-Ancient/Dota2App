using Dota2App.Models;
using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class HeroUtills
    {
        public static Hero HeroModelToHeroMap(HeroModel hModel)
        {
            Hero hero = new Hero(hModel);

            AttributeProcessor.AddStrength(ref hero, hModel.BaseStrength);
            AttributeProcessor.AddAgility(ref hero, hModel.BaseAgility);
            AttributeProcessor.AddAIntellect(ref hero, hModel.BaseIntellect);
            
            return hero;
        }

        public static Hero InitHero(ref Hero hero)
        {
            AttributeProcessor.AddStrength(ref hero, hero.BaseStrength);
            AttributeProcessor.AddAgility(ref hero, hero.BaseAgility);
            AttributeProcessor.AddAIntellect(ref hero, hero.BaseIntellect);
            return hero;
        }
    }
}
