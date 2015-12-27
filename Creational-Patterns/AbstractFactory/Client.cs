using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern
{
    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
}
