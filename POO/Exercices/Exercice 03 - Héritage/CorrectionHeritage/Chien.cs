using System;

class Chien:Animal
{
    private String Couleur; // {get; set;}

    public Chien(String Nom, String Couleur):base(Nom)
    {
        this.Couleur = Couleur;
    }

    public String GetCouleur()
    {
        return this.Couleur;
    }

    public void SetCouleur(String Couleur)
    {  
        this.Couleur = Couleur;
    } // 

    public override String ToString()
    {
        return base.ToString() + " Je suis un chien de couleur " + this.Couleur;
    }
}


