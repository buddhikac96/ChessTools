using Interfaces;

namespace ChessNotaion2.Utils
{
    public class User : IUser
    {
        public string Name { get ; set ; }
        public string Password { get ; set; }
    }
}
