using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton2_2
{
    class A
    {
        private A()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // ------------
            // コンパイルエラー"アクセスできない保護レベル担っています。"が発生します。
            // ------------
            new A();
        }
    }
}
