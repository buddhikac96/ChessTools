﻿using ChessTools;
using ChessTools.Games;
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
            catch
            {
                Console.WriteLine("Something gone wrong . . . !");
            }
        }

        static void Run()
        {
            GameMessages.AppStartMessage();
            GameLoop();
        }

        static void GameLoop()
        {
            GameMessages.GameSelectMessage();
            var game = GameSelection();
            game.start();
            Console.Write(">> Do you want to play again ? [Y / N] > ");
            var again = Console.ReadLine();
            if(again.ToLower() == "y" || again.ToLower() == "yes")
            {
                Console.WriteLine("\n");
                GameLoop();
            }
            GameMessages.GameEndMessage();
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
