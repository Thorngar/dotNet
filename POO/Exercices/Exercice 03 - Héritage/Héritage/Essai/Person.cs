using System;

    public class Person
    {
        protected String Nom;
        protected String Prenom;

        public Person(String Nom, String Prenom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
        }
        public virtual String GetInfos()
        {
            return this.Nom + this.Prenom;
        }
    }
