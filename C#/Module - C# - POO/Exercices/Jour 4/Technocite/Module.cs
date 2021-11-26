using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technocite
{
    class Module
    {
        private int Heures;
        private Formateur Formateur;
        private SujetEnum SujetEnum;

        public Module(int heures, Formateur formateur, SujetEnum sujetEnum)
        {
            this.Heures = heures;
            this.SujetEnum = sujetEnum;

            SetFormateur(formateur, sujetEnum);
        }

        public void SetFormateur(Formateur f, SujetEnum sujetEnum)
        {
            if (sujetEnum == f.GetSujetEnum())
            {
                this.Formateur = f;
            }
        }

        public override string ToString()
        {
            if (this.Formateur != null)
            {
                return
                    "[ Sujet : " + this.SujetEnum +
                    ", Formateur : " + this.Formateur.ToString() +
                    ", Heures : " + this.Heures + "]" + "\n";
            }
            else
            {
                return
                    "[ Sujet : " + this.SujetEnum +
                    ", Formateur : " + 
                    ", Heures : " + this.Heures + "]" + "\n";
            }

        }
    }
}
