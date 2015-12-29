using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Abstractions
{
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component c)
        {
            component = c;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
