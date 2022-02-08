namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Оружие
    /// </summary>
    internal abstract class Weapon : IAction
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public string Name { get; set; } = "Оружие";

        protected Weapon(string Name, int Damage, int Durability)
        {
            this.Name = Name;
            this.Damage = Damage;
            this.Durability = Durability;
        }

        public void Cure(int treatment)
        {
            throw new System.NotImplementedException();
        }

        public void GetDamage(int damage)
        {
            throw new System.NotImplementedException();
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name}\n Урон - {Damage}\n Состояние - {Durability}\n";
        }
    }
}