using FlyWeightPattern.Abstractions;
using FlyWeightPattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 25;

            FlyweightFactory factory = new FlyweightFactory();
            Flyweight f1 = factory.GetFlyweight("X");
            f1.Operation(--extrinsicstate);

            Flyweight f2 = factory.GetFlyweight("Y");
            f2.Operation(--extrinsicstate);

            Flyweight f3 = factory.GetFlyweight("Z");
            f3.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);

            Console.ReadLine();
        }
    }
}
