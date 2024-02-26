using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Days : IPrinter
    {
        public void array_output()
        {
            Console.WriteLine("Дни недели: понедельник, вторник, среда, четверг, пятница, суббота, воскресенье.");
        }
    }
}
