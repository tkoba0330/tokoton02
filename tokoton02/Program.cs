﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton02
{
    class A
    {
        internal A()
        {
            throw new ApplicationException("クラスAはnewできません。");
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            new A();
        }
    }
}
