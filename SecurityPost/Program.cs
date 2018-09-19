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
        static public int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Меню: 
               1. Список всех пользователей
               2. Добавить пользователя
               3. Удалить пользователя
               4. Измениить пользователя
               0. Выход");

            string menu = Console.ReadLine();
            return Convert.ToInt32(menu);
        }

        static void Main(string[] args)
        {
            List<User> UsersList = new List<User>();

            int userInput = 0;

            do
            {
                //доделать цикл. очищает и не показывает список всех поль-лей
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case (1):
                        //Console.Clear();
                        foreach (var userr in UsersList)
                            Console.WriteLine($"Логин: {userr.Login}\t" + $"Номер телефона: {userr.PhoneNumber}");
                        break;
                    case (2):
                        //Console.Clear();
                        User user = new User();
                        user.UserCreate();
                        UsersList.Add(user);
                        Console.ReadLine();
                        break;
                    case (3):
                        //Console.Clear();
                        int delNum = 0;
                        Console.WriteLine("Выберите порядковый номер пользователя для удаления (0-9)");
                        string text = Console.ReadLine();
                        bool isParsed = int.TryParse(text, out delNum);

                        if (!isParsed)
                        {
                            Console.WriteLine("Некорректный ввод!");
                            return;
                        }
                        else
                            UsersList.RemoveAt(delNum);
                        break;
                }
            } while (userInput != 0);

        }
    }
}
