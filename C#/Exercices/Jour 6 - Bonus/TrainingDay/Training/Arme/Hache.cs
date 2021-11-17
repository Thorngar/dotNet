using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Arme
{
    class Hache : Arme
    {
        private int BonusForce;

        public Hache(string name, int degats, int force) : base(name, degats)
        {
            this.Name = name;
            this.Degats = degats;
            this.BonusForce = force;
        }
        public override int GetDegats()
        {
            return this.BonusForce + this.Degats;
        }

        public int GetBonusForce()
        {
            return this.BonusForce;
        }

        public override string ToString()
        {
            return
                "\n" +
                "|----------> Votre Arme"+ "\n" +
                "|----------> " + this.Name + "\n" +
                "|----------> Ses dégâts" + "\n" +
                "|----------> " + this.Degats + "\n" +
                "|----------> Son bonus de Force" + "\n" +
                "|----------> " + this.BonusForce + "\n";
        }
    }
}
