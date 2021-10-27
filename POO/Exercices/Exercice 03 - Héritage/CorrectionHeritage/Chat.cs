using System;

class Chat:Animal
{
    private int Age;

    public Chat(String Nom, int Age):base(Nom)
    {
        this.Age = Age;
    }

    public override String ToString()
    {
        return base.ToString() + "Je suis un chat et mon âge est de " + this.Age + " ans";
    }
}
