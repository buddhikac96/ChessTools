using System;
using System.IO;
using System.Linq;

namespace ChessTools
{
    public class Game
    {
        int number_of_rounds;
        Board board;

        public Game(int rounds)
        {
            number_of_rounds = rounds;
            board = new Board();
        }

        public int start()
        {
            int marks = evaluate();
            return marks;
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
                Console.Write(">> ");

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

            if(!valid_inputs.Any(color => color == input))
            {
                throw new InvalidDataException("Invalid Color input");
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
