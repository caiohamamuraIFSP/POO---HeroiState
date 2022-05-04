public interface IMoral
{
    public void Ataca();
    public void Nadar();
    public void Defender();
    public void AbaixarMoral(Heroi heroi);
    public void ElevarMoral(Heroi heroi);
}

public class MoralAlta : IMoral
{
    public void AbaixarMoral(Heroi heroi)
    {
        heroi.moral = new MoralMedia();
    }

    public void Ataca()
    {
        System.Console.WriteLine("Seu ataque é super efetivo!");
    }

    public void Defender()
    {
        System.Console.WriteLine("Você desvia de todos os ataques como um ninja!");
    }

    public void ElevarMoral(Heroi heroi)
    {
    }

    public void Nadar()
    {
        System.Console.WriteLine("Você nada super rápido!");
    }
}

public class MoralMedia : IMoral
{
    public void AbaixarMoral(Heroi heroi)
    {
        heroi.moral = new MoralBaixa();
    }
    public void Ataca()
    {
        System.Console.WriteLine("Você atacou!");
    }

    public void Defender()
    {
        System.Console.WriteLine("Você consegue aparar alguns ataques!");
    }

    public void ElevarMoral(Heroi heroi)
    {
        heroi.moral = new MoralAlta();
    }

    public void Nadar()
    {
        System.Console.WriteLine("Você está nadando!");
    }
}

public class MoralBaixa : IMoral
{
    public void AbaixarMoral(Heroi heroi)
    {
    }
    public void Ataca()
    {
        System.Console.WriteLine("Você está fraco para atacar!");
    }

    public void Defender()
    {
        System.Console.WriteLine("Você tomou todos os ataques!");
    }

    public void ElevarMoral(Heroi heroi)
    {
        heroi.moral = new MoralMedia();
    }

    public void Nadar()
    {
        System.Console.WriteLine("Você se afogou!");
    }
}


public class Heroi
{
    public IMoral moral = new MoralMedia();
    public Heroi(IMoral moral) 
    {
        this.moral = moral;
    }

    public void Ataca() 
    {
        moral.Ataca();
    }

    public void Defender() 
    {
        moral.Defender();
    }

    public void Nadar() 
    {
        moral.Nadar();
    }

    public void AbaixarMoral()
    {
        moral.AbaixarMoral(this);
    }

    public void ElevarMoral()
    {
        moral.ElevarMoral(this);
    }
}
