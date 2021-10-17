using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class B : A , InterfaceB, InterfaceC
    {
        public override void MethodA()
        {
            base.MethodA();
            Console.WriteLine("MethodA");
        }
        public void MethodB()
        {
            Console.WriteLine("MethodB");
        }
    }
}
