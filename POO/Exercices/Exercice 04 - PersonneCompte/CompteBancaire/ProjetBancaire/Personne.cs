public class Person:CompteCour
{
    private string Nom;
    private string Prénom;
    public Person(double Base, double Montant, string Nom, string Prénom):base(Base,Montant)
    {
        this.Nom = Nom;
        this.Prénom = Prénom;
    }

    public virtual string GetInfo()
    {
        return this.Nom + this.Prénom + " je possède sur mon compte épargne " + this.Base + " euros et sur mon compte courant " + this.Montant + " euros";
    }
}