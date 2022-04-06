using System;
using System.Threading;

namespace _007Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/

            /*Layout*/
            #region Layout do sistema
            Console.Title = "StopWatch";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            #endregion
            /**/

            /**/
            Console.Clear();
            Menu();

            Console.ReadLine();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.Write("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0,data.Length - 1));

            int multiplier = 1;
            if(type == 'm')
            {
                multiplier = 60;
            }

            if(time == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.Write("Read ");
            Thread.Sleep(1000);
            Console.Write("Set ");
            Thread.Sleep(1000);
            Console.Write("Go...");
            Thread.Sleep(1000);
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"Tempo Atual: {currentTime}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("StopWatch Finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
