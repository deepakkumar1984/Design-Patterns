using BridgePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementations
{
    class ConcreteImplementationA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementationA Operation Called");
        }
    }
}
