using PrototypePattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Implementations
{
    class ConcretePrototypeB : Prototype
    {
        public ConcretePrototypeB(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
