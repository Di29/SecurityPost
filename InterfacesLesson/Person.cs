using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public abstract class Person
    {
        public string FullNAme { get; set; }

        public DateTime BirthDate { get; set; }

        public string Adress { get; set; }

        public string PhoneNumber { get; set; }
    }
}
