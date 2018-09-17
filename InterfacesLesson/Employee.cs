using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public class Employee : Person, IWorkerContract
    {
        public int HoursOfWork { get ; set ; }

        public void DoWork(int countOfRest)
        {
            Console.WriteLine("Сотрудник выполняет свою работу");
        }
    }
}
