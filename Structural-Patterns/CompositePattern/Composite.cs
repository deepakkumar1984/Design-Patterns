using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : Component
    {
        public List<Component> components = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            components.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (var item in components)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            components.Remove(c);
        }
    }
}
