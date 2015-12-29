using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class SubSystemA
    {
        public void Method()
        {
            Console.WriteLine("SubSystemA Method()");
        }
    }

    class SubSystemB
    {
        public void Method()
        {
            Console.WriteLine("SubSystemB Method()");
        }
    }
    class SubSystemC
    {
        public void Method1()
        {
            Console.WriteLine("SubSystemC Method1()");
        }

        public void Method2()
        {
            Console.WriteLine("SubSystemC Method2()");
        }
    }
}
