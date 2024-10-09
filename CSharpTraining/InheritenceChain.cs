using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpTraining
{
    class A
    {
        static A()
        {
            Console.WriteLine("Static A");
        }
        public A()
        {
            Console.WriteLine("public AA");
        }
    }

    class B : A
    {
        static B()
        {
            Console.WriteLine("Static B");
        }
        public B()
        {
            Console.WriteLine("public BB");
        }
    }

    class C : B
    {
        static C()
        {
            Console.WriteLine("Static C");
        }
        public C()
        {
            Console.WriteLine("public BB");
        }
    }


    public class InheritenceChain
    {
        public static void Main(string[] args)
        {
            C c= new C();
            Console.ReadLine();
        }
    }

}
