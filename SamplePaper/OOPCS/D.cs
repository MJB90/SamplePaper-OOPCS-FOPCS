using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class D : A, InterfaceB
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB");
        }

        public override void MethodC()
        {
            base.MethodC();
            Console.WriteLine("MethodC");
        }
    }
}
