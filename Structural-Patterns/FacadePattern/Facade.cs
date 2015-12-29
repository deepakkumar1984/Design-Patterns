using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Facade
    {
        private SubSystemA systemA;
        private SubSystemB systemB;
        private SubSystemC systemC;

        public Facade()
        {
            systemA = new SubSystemA();
            systemB = new SubSystemB();
            systemC = new SubSystemC();
        }

        public void MethodA()
        {
            Console.WriteLine("Facade MethodA()");
            systemA.Method();
            systemB.Method();
            systemC.Method1();
        }

        public void MethodB()
        {
            Console.WriteLine("Facade MethodB()");
            systemA.Method();
            systemC.Method1();
            systemC.Method2();
        }
    }
}
