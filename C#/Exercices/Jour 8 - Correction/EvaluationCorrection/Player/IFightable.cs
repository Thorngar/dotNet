

namespace EvaluationCorrection.Player
{
    interface IFightable
    {
        void Attack(Player p);

        void ReceiveDamage(int dmg);
    }
}
