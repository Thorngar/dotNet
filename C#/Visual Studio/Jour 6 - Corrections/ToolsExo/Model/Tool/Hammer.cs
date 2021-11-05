
namespace ToolsExo
{
    class Hammer : Tool
    {
        public Hammer(string name, int price)
        {
            this.Name = name;
            this.Price = price;
            this.ToolDamage = 15;
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
