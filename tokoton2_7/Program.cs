using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton2_7
{
    static class A
    {
        internal static void WhoAreYou(Action action = null)
        {
            try
            {
                if (action != null)
                {
                    action();
                    return;
                }

                Console.WriteLine("I am A!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            A.WhoAreYou();

            A.WhoAreYou(() => Console.WriteLine("I am B!"));
        }
    }
}
