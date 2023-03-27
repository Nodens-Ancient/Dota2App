using Dota2App.Models.DTO;

namespace Dota2App.Core
{
    public class LevelProcessor
    {
        public static Hero SetHeroLevel(ref Hero hero, int level = 1)
        {
            if (level <= 0) level = 1;
            //hero. = level;
            AttributeProcessor.AddStrength(ref hero, (level - 1) * hero.StrengthGain);
            AttributeProcessor.AddAgility(ref hero, (level - 1) * hero.AgilityGain);
            AttributeProcessor.AddIntellect(ref hero, (level - 1) * hero.IntellectGain);
            return hero;
        }
    }
}
