namespace Dota2App.Models.DTO
{
    public class Hero
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string MainAttribute { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; }
        public float HealthRegen { get; set; }
        public float ManaRegen { get; set; }
        public float Armor { get; set; }
        public float MagicResist { get; set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Intellect { get; set; }
        public float Damage { get; set; }
        public float AttackSpeed { get; set; }
        public int Level { get; set; }
        public float StrengthGain { get; set; }
        public float AgilityGain { get; set; }
        public float IntellectGain { get; set; }
    }
}
