namespace Dota2App.Models.DTO
{
    public class Hero : HeroModel
    {
        public float Strength { get; private set; }
        public float Agility { get; private set; }
        public float Intellect { get; private set; }
        public float HealthRegen { get; private set; }
        public float ManaRegen { get; private set; }
        public float Damage { get; private set; }
        public float Health { get; private set; }
        public float Mana { get; private set; } 
        public int Level { get; private set; }
        public float Armor { get; private set; }
        public float Evasion { get; private set; }
        public float MagicResist { get; private set; }
        public float PhysResist { get; private set; }
        public float BonusMSPercentageSpeed { get; private set; }
        public int BonusMSStaticSpeed { get; private set; }
        public int MoveSpeed { get; private set; }
        public float StatusResistance { get; private set; }

        public void AddStrength(float str) => Strength += str;
        public void AddAgility(float agi) => Agility += agi;
        public void AddIntellect(float intellect) => Intellect += intellect;
        public void AddHealthRegen(float hReg) => HealthRegen += hReg;
        public void AddManaRegen(float mReg) => ManaRegen += mReg;
        public void AddMana(float mana) => Mana += mana;
        public void AddHealth(float health) => ManaRegen += health;
        public void AddDamage(float dmg) => Damage += dmg;
        public void AddNightVision(float nVision) => NightVision += nVision;

        public void AddMoveSpeed(float ms)
        {
            BonusMSStaticSpeed += (int)ms;
            MoveSpeed += (int)ms;
        }

        public void AddMoveSpeedPercent(float msPersent)
        {
            BonusMSPercentageSpeed += msPersent;
            MoveSpeed = (int)((BaseMoveSpeed + BonusMSStaticSpeed) * (1 + BonusMSPercentageSpeed));
        }
        public void AddArmor(float armr)
        {
            Armor += armr;
            PhysResist = (0.052f * Armor) / (0.9f + 0.048f * Armor);
        }
        public void AddEvasion(float evasion)
        {
            var ev = Evasion / 100.0f;
            Evasion = (ev + (1 - ev) * evasion) * 100;
        }
        public void AddMagicResist(float resist)
        {
            var mr = MagicResist / 100.0f;
            MagicResist = (mr + (1 - mr) * resist) * 100;
        }
        public void AddAttackSpeed(float spd) => AttackSpeed += spd;
        public void AddAttackRange(float range) => AttackRange += (int)range;
        public void AddStatusResistance(float res) => StatusResistance += res;

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
            BaseMoveSpeed = heroModel.BaseMoveSpeed;
            Damage = (heroModel.BaseAttackDamageMax + heroModel.BaseAttackDamageMin) / 2.0f;

            Health = BaseHealth;
            Mana = BaseMana;
            MagicResist = BaseMagicResist;
            MoveSpeed = BaseMoveSpeed;
        }
    }
}
