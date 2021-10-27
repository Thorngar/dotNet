using System;

public class Employee:Person
{
    private int id;

    public Employee(String Nom, String Prenom, int id):base(Nom, Prenom)
    {
        this.id = id;
    }
    public override String GetInfos()
    {
        return "Nom : " + this.Nom + "\n" +
               "Prénom : " + this.Prenom + "\n" +
               "ID : " + this.id;
    }
}