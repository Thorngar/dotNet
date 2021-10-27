public abstract class Abstract
{
    protected int Age;
    public virtual void Vieillir()
    {
        this.Age++;
    }
    public abstract string Aboyer();

    public string GetInfo()
    {
        if(this.Age >= 1)
        {
            if(this.Age == 1)
            {
                return this.Age + " an";
            } else
                {
                    return this.Age + " ans";
                }
        } else 
            {
            return "Le chien n'existe pas";
            }
    }
}

