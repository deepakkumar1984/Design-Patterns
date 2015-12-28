using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Composite("Root Leaf 1"));
            root.Add(new Composite("Root Leaf 2"));

            Composite comp = new Composite("Parts");
            comp.Add(new Composite("Parts Leaf 1"));
            comp.Add(new Composite("Parts Leaf 2"));

            root.Add(comp);
            root.Add(new Composite("Leaf 3"));

            root.Display(1);
            Console.ReadLine();
        }
    }
}
