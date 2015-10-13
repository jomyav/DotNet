using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello: From B
            A a1 = new B();
            a1.show();

            //Hello: From A
            A a2 = new C();
            a2.show();

            //Hello: From D
            D d1 = new E();
            d1.show();

            //Hello: From D
            D d2 = new F();
            d2.show();

            //Hello: From A
            A a3 = new G();
            a2.show();

        }
    }
}
