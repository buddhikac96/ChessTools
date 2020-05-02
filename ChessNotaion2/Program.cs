using ChessNotaion2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTools
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch(InvalidDataException e)
            {
                Console.WriteLine("You have entered a invalid color. Are you color blind or something. There is only two colors fool!");
            }
            Console.ReadLine();
        }

        static void Run()
        {
            GameMessages.AppStartMessage();
            Console.Write(">> Enter number of rounds - ");
            int rounds = Int32.Parse(Console.ReadLine());

            var game = new Game(rounds);
            game.start();
        }
    }
}
