
namespace ToolsExo.Model.Player
{
    class Player
    {
        protected int HealthPoint;
        protected Tool Tool;

        public Player(int healthPoint, Tool tool)
        {
            this.HealthPoint = healthPoint;
            this.Tool = tool;
        }

        public int GetToolDamage()
        {
            return this.Tool.GetDamage();
        }

        public virtual void HitOpponent(Player p)
        {
            p.ReceiveDamage(this.Tool.GetDamage());
        }

        public virtual void ReceiveDamage(int dmg)
        {
            this.HealthPoint -= dmg;
        }

        public override string ToString()
        {
            return "Point de vie: " + this.HealthPoint + " Outil: " + Tool.ToString() + "\n";
        }

    }
}
