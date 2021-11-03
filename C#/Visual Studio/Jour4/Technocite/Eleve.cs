using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technocite
{
    class Eleve
    {
        private string Nom;
        private string Prenom;
        private int Age;
        private List<Module> Modules;

        public Eleve(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Modules = new List<Module>();
        }

        public void AjouterUnModule(Module m)
        {
            Modules.Add(m);
        }

        public void RetirerUnModule(Module m)
        {
            Modules.Remove(m);
        }

        public override string ToString()
        {
            string tempListModule = "";
            foreach (Module m in Modules)
            {
                tempListModule += m.ToString();
            }

            return 
                "Nom : " + this.Nom + " Prénom : " + this.Prenom + " Age : " + this.Age + "\n"
                + "==================================================================" + "\n" 
                +tempListModule + "\n";
        }
    }
}
