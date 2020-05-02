using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessNotaion2
{
    public static class GameMessages
    {   
        public static void AppStartMessage()
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
