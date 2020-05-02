using ChessNotaion2;
using ChessNotaion2.Games;
using Interfaces;
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
            GameMessages.GameSelectMessage();

            var game = GameSelection();

            game.start();
        }

        static IGame GameSelection()
        {
            Console.Write(">> Game Number - ");
            int game = Int32.Parse(Console.ReadLine());

            switch (game)
            {
                case 1:
                    Console.Write(">> Enter number of rounds - ");
                    int rounds1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    return new ColorMania(rounds1);
                default:
                    Console.Write(">> Enter number of rounds - ");
                    int rounds2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    return new ColorMania(rounds2);
            }
        }
    }
}
