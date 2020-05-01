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
            gameInitDisplay();
            Console.Write(">> Enter number of rounds - ");
            int rounds = Int32.Parse(Console.ReadLine());

            var game = new Game(rounds);
            game.start();
        }

        static void gameInitDisplay()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("**                _ _ _ _ _ _ _ _ _ _ _ _                                              **");
            Console.WriteLine("**               | + + + + + |           |                                             **");
            Console.WriteLine("**               | + + + + + |           |                                             **");
            Console.WriteLine("**               | + + + + + |   CHESS   |             1. COLOR GAME                   **");
            Console.WriteLine("**               | + + + + + |           |             2. KNIGHT GAME                  **");
            Console.WriteLine("**               |_+_+_+_+_+_|_ _ _ _ _ _|             3. BISHOP CHALLANGE             **");
            Console.WriteLine("**               |           | + + + + + |             4. BRAVE KING                   **");
            Console.WriteLine("**               |           | + + + + + |             5. PLAY CHESS                   **");
            Console.WriteLine("**               |   TOOLS   | + + + + + |             6. QUEENS GAMBIT                **");
            Console.WriteLine("**               |           | + + + + + |             6. END GAMES                    **");
            Console.WriteLine("**               |_ _ _ _ _  |_+_+_+_+_+_|                                             **");
            Console.WriteLine("**                                                                                     **");
            Console.WriteLine("**                           - - - - - - - - - - - - - - -                             **");
            Console.WriteLine("============================|| WELCOME TO THE CHESS TOOLS ||=============================");
            Console.WriteLine("                             - - - - - - - - - - - - - - -                      \n\n\n");
            
        }

    }
}
