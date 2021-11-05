
namespace ToolsExo
{
    abstract class Tool
    {
        protected string Name;
        protected int Price;
        protected int ToolDamage;

        abstract public string GetName();
        abstract public int GetPrice();
        abstract public int GetDamage();

        public override string ToString()
        {
            return "Nom: " + this.Name + " Prix: " + this.ToolDamage + " Dégâts: " + this.ToolDamage;
        }

    }
}
