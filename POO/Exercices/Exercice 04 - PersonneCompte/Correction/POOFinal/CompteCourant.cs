class CompteCourant:Compte
{
    public CompteCourant()
    {
        this.Montant = 200;
    }
    
    public CompteCourant(double Montant) // surcharge de la méthode avec un nouvel attribut
    {
        this.Montant = Montant;
    }

    public override string GetInfos()
    {
        return "Compte courant : " + this.Montant;
    }
}