using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Employee employee = new Employee();

            Person person = new Director();

            IBaseContract baseContract = new Director();
            baseContract.DoWork(5);
            (baseContract as Person).Adress = "New-York City";




        }
    }
}
