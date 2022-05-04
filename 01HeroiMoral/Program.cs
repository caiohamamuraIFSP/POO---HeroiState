using System;

namespace _01HeroiMoral
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroi = new Heroi(new MoralAlta());

            heroi.Ataca();
            heroi.Defender();
            
            Console.WriteLine();
            Console.WriteLine("Abaixando moral");
            
            heroi.AbaixarMoral();
            heroi.Ataca();
            heroi.Defender();

            Console.WriteLine();
            Console.WriteLine("Abaixando moral");
            
            heroi.AbaixarMoral();
            heroi.Ataca();
            heroi.Defender();

            Console.WriteLine();
            Console.WriteLine("Elevar moral 2x");
            
            heroi.ElevarMoral();
            heroi.ElevarMoral();
            heroi.Ataca();
            heroi.Defender();

            
        }
    }
}
