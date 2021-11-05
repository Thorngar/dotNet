
namespace ToolsExo.Model.Player
{
    class Creature : Player
    {
        public const int DamageSupp = 5;
       
        public Creature(int healthPoint, Tool tool) : base(healthPoint, tool)
        {

        }

        public override void HitOpponent(Player p)
        {
            this.HealthPoint -= (p.GetToolDamage() + DamageSupp);
        }
    }
}
