class CompteEpargne:Compte
{
    public CompteEpargne()
    {
        this.Montant = 2000;
    }

    public override string GetInfos()
    {
        return "Compte épargne : " + this.Montant;
    }
}