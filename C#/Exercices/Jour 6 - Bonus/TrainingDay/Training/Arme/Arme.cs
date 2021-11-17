using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Arme
{
    abstract class Arme
    {
        protected int Degats;
        protected string Name;

        public Arme(string name, int degats)
        {
            this.Name = name;
            this.Degats = degats;
        }

        public virtual int GetDegats()
        {
            return this.Degats;
        }
    }
}
