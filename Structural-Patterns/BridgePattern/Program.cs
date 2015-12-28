using BridgePattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.Implementor = new ConcreteImplementationA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementationB();
            abstraction.Operation();

            Console.ReadLine();
        }
    }
}
