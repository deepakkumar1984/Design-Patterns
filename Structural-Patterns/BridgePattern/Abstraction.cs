using BridgePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Abstraction
    {
        protected Implementor _implementor;

        public Implementor Implementor
        {
            set
            {
                _implementor = value;
            }
        }

        public virtual void Operation()
        {
            _implementor.Operation();
        }
    }
}
