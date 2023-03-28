using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class HeroUtills
    {
        public static Hero InitHero(ref Hero hero)
        {
            AttributeProcessor.AddStrength(ref hero, hero.BaseStrength);
            AttributeProcessor.AddAgility(ref hero, hero.BaseAgility);
            AttributeProcessor.AddIntellect(ref hero, hero.BaseIntellect);
            return hero;
        }
    }
}
