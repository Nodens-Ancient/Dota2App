namespace Dota2App.Models.DTO
{
    public class Hero : HeroModel
    {
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Intellect { get; set; }
        public float HealthRegen { get; set; }
        public float ManaRegen { get; set; }
        public float Damage { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; } 
        public int Level { get; set; }
        public float Armor { get; set; }
        public float Evasion { get; set; }
        public float MagicResist { get; set; }

        public Hero(HeroModel heroModel)
        {
            Id = heroModel.Id;
            Name = heroModel.Name;
            MainAttribute = heroModel.MainAttribute;

            BaseStrength = heroModel.BaseStrength;
            BaseAgility = heroModel.BaseAgility;
            BaseIntellect = heroModel.BaseIntellect;

            BaseHealth = heroModel.BaseHealth;
            BaseMana = heroModel.BaseMana;

            StrengthGain = heroModel.StrengthGain;
            AgilityGain = heroModel.AgilityGain;
            IntellectGain = heroModel.IntellectGain;

            BaseMagicResist = heroModel.BaseMagicResist;
            BaseHealthRegen = heroModel.BaseHealthRegen;
            BaseManaRegen = heroModel.BaseManaRegen;

            BaseArmor = heroModel.BaseArmor;
            NightVision = heroModel.NightVision;
            DayVision = heroModel.DayVision;

            BaseAttackDamageMin = heroModel.BaseAttackDamageMin;
            BaseAttackDamageMax = heroModel.BaseAttackDamageMax;
            AttackRange = heroModel.AttackRange;

            AttackSpeed = heroModel.AttackSpeed;
            MoveSpeed = heroModel.MoveSpeed;
            Damage = (heroModel.BaseAttackDamageMax + heroModel.BaseAttackDamageMin) / 2.0f;

            Health = BaseHealth;
            Mana = BaseMana;
            MagicResist = BaseMagicResist;
        }
    }
}
