namespace Technocite
{
    class Formateur
    {
        private string Nom;
        private string Prenom;
        private SujetEnum SujetEnum;

        public Formateur(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public Formateur(string nom, string prenom, SujetEnum sujetEnum)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.SujetEnum = sujetEnum;
        }

        public SujetEnum GetSujetEnum()
        {
            return this.SujetEnum;
        }
        public override string ToString()
        {
            return "Nom : " + this.Nom + " Prénom : " + this.Prenom;
        }
    }
}