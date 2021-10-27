using System;

class Animal
{
    private String Nom;
    
    public Animal(String Nom)
    {
        this.Nom = Nom;
    }

    public override String ToString()
    {
        return "Je suis un animal";
    } 
}