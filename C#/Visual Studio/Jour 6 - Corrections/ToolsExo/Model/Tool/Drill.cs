
namespace ToolsExo
{
    class Drill : Tool
    {
        public Drill(string name, int price)
        {
            this.Name = name;
            this.Price = price;
            this.ToolDamage = 20;
        }

        public override string GetName()
        {
            return Name;
        }

        public override int GetPrice()
        {
            return Price;
        }

        public override int GetDamage()
        {
            return ToolDamage;
        }
    }
}
