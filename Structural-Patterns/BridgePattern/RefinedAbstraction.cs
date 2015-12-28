using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _implementor.Operation();
        }
    }
}
