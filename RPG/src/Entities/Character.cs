namespace RPG.src.Entities
{
    public abstract class Character
    {
        public string? Name { get;private set; }
        public int Level { get;private set; }
        public string? Type { get;private set; }
        public Character(string Name,int Level,string Type)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
        }

        public virtual string Attack()
        {
            return $"{Name} atacou com a espada";
        }
        public virtual string Attack(int bonus)
        {
            return $"{Name} atacou com bonus de {bonus}";
        }
    }
}