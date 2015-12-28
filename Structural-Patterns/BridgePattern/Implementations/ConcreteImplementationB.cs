using BridgePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementations
{
    class ConcreteImplementationB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementationB Operation Called");
        }
    }
}
