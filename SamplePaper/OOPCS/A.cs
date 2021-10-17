using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class A : InterfaceA , InterfaceC
    {
        public virtual void MethodA()
        {
            Console.WriteLine("MethodA");
        }
        public virtual void MethodC()
        {
            Console.WriteLine("MethodC");
        }
    }
}
