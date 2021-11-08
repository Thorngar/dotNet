using System;

namespace Jour2
{
    class Animal
    {
        private string Espece;
        
        public Animal()
        {
            
        }

        public Animal(string Espece)
        {
            this.Espece = Espece;
        }

        public void SetEspece(string newEspece)
        {
            this.Espece = newEspece;
        }

        public string GetEspece()
        {
            return this.Espece;
        }

        private string Crier()
        {
            return "Grahou";
        }

        public override string ToString()
        {
            return this.Espece + this.Crier();
        }
    }
}
