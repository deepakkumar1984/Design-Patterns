using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern
{
    //Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadLine();
        }
    }
}
