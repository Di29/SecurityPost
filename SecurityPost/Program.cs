using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SecurityPost
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> UsersList = new List<User>();
            Console.WriteLine(@"Меню: 
               1. Список всех пользователей
               2. Добавить пользователя
               3. Удалить пользователя
               4. Измениить пользователя");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case ("1"):
                    User user = new User();
                    user.UserCreate();
                    UsersList.Add(user);
                    break;
            }























            
        }
    }
}
