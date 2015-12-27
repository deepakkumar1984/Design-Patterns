using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Implementation;
using BuilderPattern.Abstracts;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            Product p1 = builder1.GetResult();
            p1.Show();

            director.Construct(builder2);
            Product p2 = builder2.GetResult();
            p2.Show();

            Console.ReadLine();
        }
    }
}
