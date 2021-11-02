using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Vanne
    {
        private bool IsOpen;

        public Vanne()
        {
            this.IsOpen = false;
        }

        public Vanne(bool IsOpen)
        {
            this.IsOpen = IsOpen;
        }

        public void SwitchVanneState()
        {
            this.IsOpen = !this.IsOpen;
        }

        public override string ToString()
        {
            return "La vanne est " + (IsOpen ? "ouverte" : "fermée");
        }
    }
}
