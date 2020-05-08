using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessNotaion2.Utils
{
    public class UserController
    {
        public IUser Player{ get; set; }

        public IUser CreateUser()
        {
            Player = new User();
            Console.Write(">> Enter Name - ");
            Player.Name = Console.ReadLine();

            Player.Password = getPassword();

            return Player;
        }

        private string getPassword()
        {
            Console.Write(">> Enter pasword - ");
            var password = Console.ReadLine();

            Console.Write(">> Confirm Password - ");
            var confirmPassword = Console.ReadLine();

            if (!password.Equals(confirmPassword))
            {
                Console.WriteLine("Password and Confirm Password not matched!");
                getPassword();
            }

            return password;
        }
    }
}
