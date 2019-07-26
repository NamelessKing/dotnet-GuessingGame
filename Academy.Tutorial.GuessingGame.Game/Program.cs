using System;

namespace Academy.Tutorial.GuessingGame.Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(DateTime.Now.Millisecond);
            int attempt = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("ho generato un numero prova a indovinare");

                int number = random.Next(1, 100);

                Console.WriteLine($"il numero e {number}");

                while (true)
                {
                    Console.Write("Indovina numero da 1 a 100: ");
                    string input = Console.ReadLine();

                    int value = 0;

                    // TryParse è metodo statico,prende una stringa e guarda se e convertibile in int32
                    bool isnumber = int.TryParse(input, out value);

                    if (!isnumber)
                    {

                        Write("non hai messo un numero valido", ConsoleColor.Red);
                        continue;
                    }

                    if (value < 1 || value > 100)
                    {
                        Write("il numero deve essere tra 1-100", ConsoleColor.Red);
                        continue;
                    }

                    var result = Math.Sign(number - value);
                    attempt++;
                    if (result == 0)
                    {
                        Write("bravo hai indovinato", ConsoleColor.Green);

                        Console.WriteLine($"tentativi: {attempt}");
                        Write("Premi invio per un nuovo gioco", ConsoleColor.Cyan);
                        Console.ReadLine();
                        break;

                    }
                    else if (result > 0)
                    {
                        Write("il numero e maggiore", ConsoleColor.Red);
                        continue;
                    }
                    else if (result < 0)
                    {
                        Write("il numero e minore", ConsoleColor.Red);
                        continue;
                    }

                }
            }

        }

        static void Write(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
