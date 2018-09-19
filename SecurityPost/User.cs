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
    public class User: ITwilio, IUserMethod
    {
        const string _accountSid = "AC21972c77ed7f6cb6d8e53a6e91e73544";
        const string _accountToken = "216baea766b06c889b04454533e820b6";
        const int RANDOM_MIN = 0000;
        const int RANDOM_MAX = 9999;
        int _verifyCode;
        int userCode = 0;
        Random random = new Random();

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

        public void UserCreate()
        {
            Console.WriteLine("Введите логин: ");
            Login = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            Password = Console.ReadLine();

            Console.Write("Введите номер телефона:+7 ");
            PhoneNumber = Console.ReadLine();

            _verifyCode = RandomNumber(RANDOM_MIN, RANDOM_MAX);
            SmsSend(_accountSid, _accountToken, PhoneNumber, _verifyCode);

            Console.WriteLine("Сейчас на ваш номер придет СМС с кодом. Введите его ниже: ");
            string text = Console.ReadLine();

            bool isParsed = int.TryParse(text, out userCode);
            if (!isVerifyed(_verifyCode, userCode))
            {
                Console.WriteLine("Не правильный код!");
            }
            else
                Console.WriteLine("Верификация прошла успешно");
        }

        public void SmsSend(string accountSid, string accountToken, string ToPhoneNumber, int verifyCode)
        {
            accountSid = _accountSid;
            accountToken = _accountToken;

            TwilioClient.Init(accountSid, accountToken);

            var message = MessageResource.Create(
                body: verifyCode.ToString(),
                from: new PhoneNumber("+13163303949"),
                to: new PhoneNumber("+7" + ToPhoneNumber)
                );
        }

        public int RandomNumber(int minNum, int maxNum)
        {
            return random.Next(minNum, maxNum);
        }

        public bool isVerifyed(int recievedNum, int userNum)
        {
            if (recievedNum != userNum)
                return false;
            else return true;
        }


    }
}
