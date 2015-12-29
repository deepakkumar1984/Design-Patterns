using DecoratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Implementations
{
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedOperation();
            Console.WriteLine("ConcreteDecoratorA Operation()");
        }

        void AddedOperation()
        {
            Console.WriteLine("ConcreteDecoratorA AddedOperation()");
        }
    }
}
