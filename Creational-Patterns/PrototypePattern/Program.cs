using PrototypePattern.Abstracts;
using PrototypePattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype p1 = new ConcretePrototypeA("ABC");
            Prototype c1 = p1.Clone();
            Console.WriteLine("Cloned : " + c1.ID);

            Prototype p2 = new ConcretePrototypeA("XYZ");
            Prototype c2 = p2.Clone();
            Console.WriteLine("Cloned : " + c2.ID);

            Console.ReadLine();
        }
    }
}
