using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton2_6
{
    static class A
    {
        internal static Action Say = () => Console.WriteLine("I am A!");

        internal static void WhoAreYou()
        {
            Say();

            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A.WhoAreYou();

            A.Say = () => Console.WriteLine("I am B!");

            A.WhoAreYou();
        }
    }
}
