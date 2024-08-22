using System;
namespace DogAgeCalculator
{
    public class Menu
    {
        public static void MenuCalculator()
        {
            Console.WriteLine(" Vamos escobrir qual sua idade em anos de cachorro? ");
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

            if (idade >= 20)

            {
                Console.WriteLine("Que gracinha! Ainda está dando seus primeiros latidos. AUAU");
            }

            else if (idade <= 60)
            {
                Console.WriteLine("Que gracinha! Já é um vovô cão. AUAU");
            }

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
