public interface IArma
{
    public void Ataque();
}

public class Espada : IArma
{
    public void Ataque()
    {
        System.Console.WriteLine("Golpeou com a espada!");
    }
}

public class Arco : IArma
{
    public void Ataque()
    {
        System.Console.WriteLine("Atirou uma flecha!");
    }
}

public class Heroi
{
    public IArma arma;
    public Heroi(IArma arma) 
    {
        this.arma = arma;
    }

    public void Atacar()
    {
        System.Console.WriteLine("Começou o ataque...");

        if (arma == null)
        {
            System.Console.WriteLine("Deu um soco!");
        } 
        else 
        {
            arma.Ataque();
        }

        System.Console.WriteLine("Terminou o ataque...");
        System.Console.WriteLine();
    }
}