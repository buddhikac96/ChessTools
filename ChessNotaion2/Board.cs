using System.Collections.Generic;

namespace ChessTools
{
    public class Board
    {
        public Dictionary<string, Color> board;
        private List<string> _cell_array;

        public Board()
        {
            board = new Dictionary<string, Color>();
            _cell_array = new List<string>();

            string[] files = { "A", "B", "C", "D", "E", "F", "G", "H" };
            string[] lines = { "1", "2", "3", "4", "5", "6", "7", "8" };

            var color = Color.Black;

            foreach (var file in files)
            {
                foreach (var line in lines)
                {
                    var cell = file + line;
                    board.Add(cell, color);
                    _cell_array.Add(cell);
                    color = swap_color(color);
                }
                color = swap_color(color);
            }
        }

        private Color swap_color(Color color)
        {
            if(color == Color.Black)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }

        public string get_cell(int index)
        {
            return _cell_array[index];
        }
    }
}
