using ChessTools;
using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChessNotaion2.Games
{
    class ColorMania : IGame
    {
        int number_of_rounds;
        Board board;

        public ColorMania(int rounds)
        {
            number_of_rounds = rounds;
            board = new Board();
        }

        public void start()
        {
            printDescription();
            int marks = evaluate();
            printEnd(marks);
        }

        private void printDescription()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("||              WELCOME TO THE COLOR MANIA                  ||");
            Console.WriteLine("==============================================================");
            Console.WriteLine("\n");
            Console.WriteLine("Instructions:");
            Console.WriteLine("     *Enter the color of the cell");
            Console.WriteLine("     *White => W / w / white / White / WhItE");
            Console.WriteLine("     *Black => B / b / black / Black / BlAcK\n");

            string letter_loop = "+ + + Here you go . . . GOOD LUCK! + + +";

            letter_loop.ToList().ForEach(letter => {
                Console.Write(letter);
                Thread.Sleep(100);
            });
            Thread.Sleep(500);

            Console.WriteLine("\n");
        }

        private void printEnd(int marks)
        {
            string letter_loop = "WELDONE! You got " + marks + " out of " + number_of_rounds; ;
            letter_loop.ToList().ForEach(letter => {
                Console.Write(letter);
                Thread.Sleep(100);
            });
        }

        private int evaluate()
        {
            Random random = new Random();
            int marks = 0;

            for (int round = 0; round < number_of_rounds; round++)
            {
                int num = random.Next(10000) % 64;
                var cell = board.get_cell(num);

                Console.WriteLine(">> " + (round + 1) + " - " + cell);
                Console.Write(">> Color > ");

                var user_input = Console.ReadLine();

                Color user_color = mapUserInputWithColor(user_input);

                if (user_color == board.board[cell])
                {
                    Console.WriteLine(">> [Correct]");
                    marks++;
                }
                else
                {
                    Console.WriteLine(">> [Incorrect]");
                }
                Console.WriteLine("");
            }

            return marks;
        }


        private Color mapUserInputWithColor(string input)
        {
            input = input.ToLower();

            string[] valid_inputs = { "b", "black", "w", "white" };

            while(!valid_inputs.Any(color => color == input))
            {
                Console.WriteLine(">> [Error] Invalid Color Input. Please enter one of these. [ W | w | white | White | b | B | black | Black ]");
                Console.Write(">> Color - ");
                var user_input = Console.ReadLine();
                return mapUserInputWithColor(user_input);
            }

            if (input == "b" || input == "black")
            {
                return Color.Black;
            }
            else
            {
                return Color.White;
            }
        }
    }
}

