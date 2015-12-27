using BuilderPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Implementation
{
    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part X");
        }

        public override void BuildPartB()
        {
            product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
