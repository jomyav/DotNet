using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTesting
{
    public class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: From A");
            Console.ReadLine();
        }
    }
    public class B : A
    {
        public override void show()
        {
            Console.WriteLine("Hello: From B");
            Console.ReadLine();
        }
    }

    public class C : A
    {
        public void show()
        {
            Console.WriteLine("Hello: From C");
            Console.ReadLine();
        }
    }

    public class D
    {
        public void show()
        {
            Console.WriteLine("Hello: From D");
            Console.ReadLine();
        }
    }

    public class E : D
    {
        public new void show()
        {
            Console.WriteLine("Hello: From E");
            Console.ReadLine();
        }
    }

    public class F : D
    {
        public void show()
        {
            Console.WriteLine("Hello: From F");
            Console.ReadLine();
        }
    }

    public class G : A
    {
        public new void show()
        {
            Console.WriteLine("Hello: From G");
            Console.ReadLine();
        }
    }

}
