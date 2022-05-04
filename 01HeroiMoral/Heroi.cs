public enum Moral 
{
    Alta,
    Normal,
    Baixa
};



public class Heroi
{
    Moral moral = Moral.Normal;
    public Heroi(Moral moral) 
    {
        this.moral = moral;
    }

    public void Ataca() 
    {
        if (moral == Moral.Alta) 
            System.Console.WriteLine("Seu ataque é super efetivo!");
        else if (moral == Moral.Normal)
            System.Console.WriteLine("Você atacou!");
        else
            System.Console.WriteLine("Você está fraco para atacar!");
    }

    public void Defender() 
    {
        if (moral == Moral.Alta) 
            System.Console.WriteLine("Você desvia de todos os ataques como um ninja!");
        else if (moral == Moral.Normal)
            System.Console.WriteLine("Você consegue aparar alguns ataques!");
        else
            System.Console.WriteLine("Você tomou todos os ataques!");
    }

    public void Nadar() 
    {
        if (moral == Moral.Alta) 
            System.Console.WriteLine("Você nada super rápido!");
        else if (moral == Moral.Normal)
            System.Console.WriteLine("Você está nadando!");
        else
            System.Console.WriteLine("Você se afogou!");
    }
}
