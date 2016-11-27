using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton2_5
{
    class A
    {
        internal virtual void Say()
        {
            Console.WriteLine("I am A!");
        }

        internal void WhoAreYou()
        {
            Say();

            Console.ReadLine();
        }
    }

    class B : A
    {
        internal override void Say()
        {
            Console.WriteLine("I am B!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            new A().WhoAreYou();

            new B().WhoAreYou();
        }
    }
}
