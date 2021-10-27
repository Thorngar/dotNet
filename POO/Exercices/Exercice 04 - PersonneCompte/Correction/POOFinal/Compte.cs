abstract class Compte
{
    protected double Montant;

    public void DeposerArgent(double ArgentDeposé)
    {
        this.Montant = this.Montant + ArgentDeposé;
    }
    public void RetirerArgent(double ArgentRetiré)
    {
        this.Montant = this.Montant - ArgentRetiré;
    }

    public abstract string GetInfos();

}