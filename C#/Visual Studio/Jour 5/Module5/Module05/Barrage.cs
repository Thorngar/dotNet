using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Barrage
    {
        private string NomBarrage;
        private Vanne Vanne01;

        public Barrage(string NomBarrage)
        {
            this.NomBarrage = NomBarrage;
            Vanne01 = new Vanne();
        }

        public void SwitchVanneState()
        {
            this.Vanne01.SwitchVanneState();
        }

        public override string ToString()
        {
            return this.NomBarrage + "\n" +
                   "=====================" + "\n" +
                   Vanne01.ToString();
        }
    }
}
