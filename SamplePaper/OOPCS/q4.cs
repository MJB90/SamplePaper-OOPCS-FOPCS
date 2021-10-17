using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class q4
    {
        public static void Main()
        {
            List<InterfaceA> list1 = new List<InterfaceA>();
            list1.Add(new A());
            list1.Add(new B());
            list1.Add(new B());
            //list1.Add(new E()); // Compile error
            foreach (InterfaceA obj in list1)
            {
                obj.MethodA();
            }
            Console.WriteLine(); // a new line

            List<InterfaceB> list2 = new List<InterfaceB>();
            list2.Add(new B());
            list2.Add(new D());
            //list2.Add(new A()); // Compile error
            foreach (InterfaceB obj in list2)
            {
                obj.MethodB();
            }
            Console.WriteLine(); // a new line

            List<InterfaceC> list3 = new List<InterfaceC>();
            list3.Add(new D());
            list3.Add(new D());
            //list3.Add(new C()); // Compile error
            foreach (InterfaceC obj in list3)
            {
                obj.MethodC();
            }

        }
    }
}
