using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public interface IWorkerContract:IBaseContract
    {
        // свойства, методы

        int HoursOfWork { get; set; }

        
    }
}
