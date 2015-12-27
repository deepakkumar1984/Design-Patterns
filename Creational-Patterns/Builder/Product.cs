using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Product
    {
        private List<string> parts = new List<string>();
        
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product Parts----------------------->");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
