using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityPost
{
    public interface IUserMethod
    {
        void UserCreate();

        int RandomNumber(int minNum, int maxNum);

        bool isVerifyed(int recievedNum, int userNum);
        

    }
}
