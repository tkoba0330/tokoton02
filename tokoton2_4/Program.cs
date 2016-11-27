using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton2_4
{
    static class Sample
    {
        internal static int A;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample.A = 123;

            Console.WriteLine(Sample.A);

            Console.ReadLine();
        }
    }
}
