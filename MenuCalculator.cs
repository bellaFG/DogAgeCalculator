using System;
namespace DogAgeCalculator
{
    public class Menu
    {
        public static void MenuCalculator()
        {
            Console.Clear();
            Console.WriteLine(" Vamos descobrir qual sua idade em anos de cachorro? ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.Write("Digite a sua idade: ");

            int idade;

            if (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Comando inválido.");
            }

            double idadeEmAnosDeCachorro = Calculator(idade);
            Console.WriteLine($"A sua idade em anos de cachorro é: {idadeEmAnosDeCachorro}");

            Thread.Sleep(4000);
            Console.Clear();
        }
        public static double Calculator(int idade)
        {
            double idadeEmAnosDeCachorro;

            if (idade == 1)
            {
                idadeEmAnosDeCachorro = 10.5;
            }
            else if (idade == 2)
            {
                idadeEmAnosDeCachorro = 21;
            }
            else if (idade > 2)
            {
                idadeEmAnosDeCachorro = 21 + ((idade - 2) * 4);
            }
            else
            {
                idadeEmAnosDeCachorro = 0;
            }
            return idadeEmAnosDeCachorro;
        }
    }
}
