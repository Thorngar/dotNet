public class CompteCour:CompteEp
{
    protected double Montant;
        public CompteCour(double Base, double Montant):base(Base)
    {
        this.Montant = 200 + Montant;
    }

}