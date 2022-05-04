public class Heroi
{
    string arma;
    public Heroi(string arma) 
    {
        this.arma = arma;
    }

    public void Atacar()
    {
        System.Console.WriteLine("Começou o ataque...");

        AtaqueEspecifico();

        System.Console.WriteLine("Terminou o ataque...");
        System.Console.WriteLine();
    }

    public void AtaqueEspecifico()
    {
        if (arma == "Espada")
        {
            System.Console.WriteLine("Golpeou com a espada");
        }
        else if (arma == "Arco")
        {
            System.Console.WriteLine("Atirou uma flecha");
        }
    }


}