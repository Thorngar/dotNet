using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Arme
{
    class Baton : Arme
    {
        private int BonusIntel;

        public Baton(string name, int degats, int intel) : base(name, degats)
        {
            this.Name = name;
            this.Degats = degats;
            this.BonusIntel = intel;
        }

        public override int GetDegats()
        {
            return this.BonusIntel + this.Degats;
        }

        public override string ToString()
        {
            return
                "\n" +
                "|----------> Votre Arme" + "\n" +
                "|----------> " + this.Name+ "\n" +
                "|----------> Ses dégâts" + "\n" +
                "|----------> " + this.Degats + "\n" + 
                "|----------> Son bonus d'Intelligence" + "\n" +
                "|----------> " + this.BonusIntel + "\n";

        }
    }
}
