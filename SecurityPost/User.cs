using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityPost
{
    class User
    {
        public string Login { get; set; }

        public string Password { private get; set; }

        public string PhoneNumber { get; set; }

        public User()
        {
            Login = null;
            Password = null;
            PhoneNumber = null;
        }

        public User (string login, string password, string phoneNum)
        {
            Login = login;
            Password = password;
            PhoneNumber = phoneNum;
        }

        public void UserCreate(string login, string password, string phoneNum)
        {
            Console.WriteLine("Введите логин: ");
            Login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            Password = Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            PhoneNumber = Console.ReadLine();

        }

    }
}
