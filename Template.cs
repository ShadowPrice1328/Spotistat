namespace Spotistat
{
    public partial class Spotistat
    {
        public class Template
        {
            public string ID { get; private set; }
            public string Name { get; private set; }
            public Template(string ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }
        }
    }
}