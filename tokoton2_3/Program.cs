using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton2_3
{
    static class A { }

    class Program
    {
        static void Main(string[] args)
        {
            // ---------------
            // コンパイルエラー "性的クラスのインスタンスを作成することはできません。"が発生する
            // ---------------
            new A();
        }
    }
}
