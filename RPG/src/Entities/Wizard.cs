namespace RPG.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, string Type) : base(Name, Level, Type)
        {
        }
        public override string Attack()
        {
            return $"{Name} atacou com magia";
        }
    }
}