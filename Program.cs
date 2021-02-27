using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var Game = new FizzBuzz();
            Console.WriteLine("Podanie wartości 'q' kończy działanie programu");
            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                var msg = Game.Check(GetNumber());
                Console.WriteLine(msg);
            }
        }
        public static int GetNumber()
        {
           
            
            while (true)
            {
                var val = Console.ReadLine();
                if (val == "q")
                    Environment.Exit(0);
                if (!int.TryParse(val, out int number))
                    {
                        Console.WriteLine("Podaj prawidłową liczbę!");
                        continue;
                    }
                    return number;              
            }
            
        }
    }
}
