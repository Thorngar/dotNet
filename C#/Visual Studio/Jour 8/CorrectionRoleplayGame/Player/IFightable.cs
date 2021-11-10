using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionRoleplayGame.Player
{
    interface IFightable
    {
        void Attack(Player p);

        void ReceiveDamage(int dmg);
    }
}
