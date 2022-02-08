namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Броня
    /// </summary>
    internal abstract class Armor : IAction
    {
        protected Armor(string Name, int Durability)
        {
            this.Name = Name;
            this.Durability = Durability;
        }

        public string Name { get; set; }
        public int Durability { get; set; }

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
            return $"{Name}\n состояние - {Durability}\n";        
        }
    }
}