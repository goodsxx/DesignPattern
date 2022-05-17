using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Car
    {
        private Car()
        {
            Console.WriteLine("Car is Run...");
        }
    }
}
