public class Heroi
{
    public Heroi() 
    {
    }

    public void Atacar()
    {
        System.Console.WriteLine("Começou o ataque...");

        AtaqueEspecifico();

        System.Console.WriteLine("Terminou o ataque...");
        System.Console.WriteLine();
    }

    public virtual void AtaqueEspecifico() 
    {
        System.Console.WriteLine("Você deu um soco!");
    }


}

public class Espadachim : Heroi
{

    public override void AtaqueEspecifico()
    {
        System.Console.WriteLine("Golpeu com a espada!");
    }
}

public class Arqueiro : Heroi
{

    public override void AtaqueEspecifico()
    {
        System.Console.WriteLine("Atirou uma flecha!");
    }
}
