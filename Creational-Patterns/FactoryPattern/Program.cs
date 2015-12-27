using FactoryPattern.Abstracts;
using FactoryPattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var item in creators)
            {
                Product p = item.FactoryMethod();
                Console.WriteLine("Created " + p.GetType().Name);
            }

            Console.ReadLine();
        }
    }
}
