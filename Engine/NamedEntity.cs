namespace DarkTech.Engine
{
    public class NamedEntity : Entity
    {
        public string Name { get; set; }

        public NamedEntity(string name) : base()
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Id);
        }
    }
}
