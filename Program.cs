using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Start(10);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundo");
            Console.WriteLine("M - Minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char type = Char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            
            // Console.WriteLine(data);
            Console.WriteLine(type);
            Console.WriteLine(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finish");
            Thread.Sleep(200);

        }
        
    }
}
