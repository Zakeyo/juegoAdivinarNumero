using System;

namespace juegoAdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberRandom = random.Next(0, 100);

            Console.WriteLine("Vamos a jugar el juego de adivinar el número.");
            Console.WriteLine("Intenta adivinar el número que elegí del 1 al 100");

            string input;
            int number = -1;
            int intentos = 1;

            while (number != numberRandom)
            {
                input = Console.ReadLine();

                if (!int.TryParse(input, out number) || number < 0 || number > 100)
                {
                    Console.WriteLine("Has introducido un dato inválido, debe ser un número entre el 1 y 100");
                }
                else if (number > numberRandom)
                {
                    Console.WriteLine("↓↓↓ El valor es menor ↓↓↓");
                    intentos += 1;
                }
                else if (number < numberRandom)
                {
                    Console.WriteLine("↑↑↑ El valor es mayor ↑↑↑");
                    intentos += 1;
                }
            }

            Console.WriteLine("FELICIDADES, HAS GANADO EL JUEGO!");
            Console.WriteLine($"Te ha tomado {intentos} intentos");
        }
    }
}