using ChessNotaion2.Utils;
using ChessTools;
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
            var controller = new GameController();
            controller.start();
        }
    }
}
