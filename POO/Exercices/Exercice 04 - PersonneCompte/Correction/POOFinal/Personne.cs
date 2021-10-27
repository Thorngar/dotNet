class Personne:IPersonne
{
    private string Nom;
    private string Prénom;
    private CompteCourant CompteCourant; // appel d'une autre classe
    private CompteEpargne CompteEpargne;
    public Personne(string Nom, string Prénom)
    {   
        this.Nom = Nom;
        this.Prénom = Prénom;
        this.CompteCourant = new CompteCourant();
        this.CompteEpargne = new CompteEpargne();
    }
    
    public Personne(string Nom, string Prénom, double Montant)
    {   
        this.Nom = Nom;
        this.Prénom = Prénom;
        this.CompteCourant = new CompteCourant(Montant); // refaire un constructeur dans la classe CompteCourant
        this.CompteEpargne = new CompteEpargne();
    }
    public string GetInfosPersonne()
    {
        return "Nom : " + this.Nom + "\n" + "Prénom : " + this.Prénom + "\n" +
        "===========================" + "\n" + 
        this.CompteCourant.GetInfos() + "\n" +
        this.CompteEpargne.GetInfos() + "\n";
    }
    public void AjouterArgentCompteCourant(double Montant)
    {
        this.CompteCourant.DeposerArgent(Montant);
    }
    public void RetirerArgentCompteCourant(double Montant)
    {
        this.CompteCourant.RetirerArgent(Montant);
    }
    public void AjouterArgentCompteEpargne(double Montant)
    {
        this.CompteEpargne.DeposerArgent(Montant);
    }
    public void RetirerArgentCompteEpargne(double Montant)
    {
        this.CompteEpargne.RetirerArgent(Montant);
    }

     // BONUS 1 - Transférer de l'argent entre les deux comptes
    public void TransfererVersCompteEpargne(double Montant)
    {
        this.CompteEpargne.DeposerArgent(Montant);
        this.CompteCourant.RetirerArgent(Montant);
    }
    public void TransfererVersCompteCourant (double Montant)
    {
        this.CompteCourant.DeposerArgent(Montant);
        this.CompteEpargne.RetirerArgent(Montant);
    }
    // BONUS 2 - Transférer de l'argent entre deux personnes
    public void VirementVersCompteCourant(double Montant, CompteCourant CompteCourant)
    {
        this.CompteCourant.RetirerArgent(Montant);
        CompteCourant.DeposerArgent(Montant);
    }
}