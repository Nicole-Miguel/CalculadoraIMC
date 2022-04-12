using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Individuo pessoa1 = new Individuo();

            Console.WriteLine("Qual o seu nome?");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex: 1,63");
            pessoa1.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em kg? Ex: 59,3");
            pessoa1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}.", pessoa1.Nome, pessoa1.Altura, pessoa1.Peso);  
            Console.WriteLine ("Seu IMC é {0}·", pessoa1.CalculoImc());  

        }
    }
}
