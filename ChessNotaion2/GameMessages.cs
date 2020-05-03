using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChessTools
{
    public class GameMessages
    {   
        public static void AppStartMessage()
        {
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("**                _ _ _ _ _ _ _ _ _ _ _ _                                                      **");
            Console.WriteLine("**               | + + + + + |           |                                                     **");
            Console.WriteLine("**               | + + + + + |           |                                                     **");
            Console.WriteLine("**               | + + + + + |   CHESS   |             1. COLOR GAME                           **");
            Console.WriteLine("**               | + + + + + |           |             2. KNIGHT GAME ( COMMING SOON)          **");
            Console.WriteLine("**               |_+_+_+_+_+_|_ _ _ _ _ _|             3. BISHOP CHALLANGE ( COMMING SOON)     **");
            Console.WriteLine("**               |           | + + + + + |             4. BRAVE KING ( COMMING SOON)           **");
            Console.WriteLine("**               |           | + + + + + |             5. PLAY CHESS ( COMMING SOON)           **");
            Console.WriteLine("**               |   TOOLS   | + + + + + |             6. QUEENS GAMBIT  ( COMMING SOON)       **");
            Console.WriteLine("**               |           | + + + + + |             6. END GAMES  ( COMMING SOON)           **");
            Console.WriteLine("**               |_ _ _ _ _  |_+_+_+_+_+_|                                                     **");
            Console.WriteLine("**                                                                                             **");
            Console.WriteLine("**                                - - - - - - - - - - - - - - -                                **");
            Console.WriteLine("================================|| WELCOME TO THE CHESS TOOLS ||=================================");
            Console.WriteLine("                                  - - - - - - - - - - - - - - -                                \n");
        }

        public static void GameSelectMessage()
        {
            string letter_loop = "+ + + + SELECT THE GAME + + + +";
            letter_loop.ToList().ForEach(letter => {
                Console.Write(letter);
                Thread.Sleep(100);
            });
            Console.WriteLine();
            Thread.Sleep(200);
        }
    }
}
