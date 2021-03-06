public interface IArma
{
    public void Ataque();
}

public class SemArma : IArma
{
    public void Ataque()
    {
        System.Console.WriteLine("Deu um soco!");
    }
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
    public IArma arma = new SemArma();

    public Heroi() { }
    public Heroi(IArma arma)
    {
        if (arma != null)
            this.arma = arma;
    }

    public void Atacar()
    {
        System.Console.WriteLine("Começou o ataque...");

        arma.Ataque();

        System.Console.WriteLine("Terminou o ataque...");
        System.Console.WriteLine();
    }


}