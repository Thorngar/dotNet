
namespace ToolsExo
{
    class ScrewDriver : Tool
    {
        public ScrewDriver(string name, int price)
        {
            this.Name = name;
            this.Price = price;
            this.ToolDamage = 10;
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
