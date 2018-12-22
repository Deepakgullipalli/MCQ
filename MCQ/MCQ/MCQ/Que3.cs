﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ.MCQ
{
    class Que3
    {
        public void Que3Main()
        {
            B b = new B();
            A a = b;
            a.F();
            b.F();
            a.G();
            b.G();
        }
    }

    class A
    {
        public void F()
        {
            Console.WriteLine("A----F");
        }
        public virtual void G()
        {
            Console.WriteLine("A----G");
        }
    }
    class B : A
    {
        new public void F()
        {
            Console.WriteLine("B----F");
        }
        public override void G()
        {
            Console.WriteLine("B----G");
        }
    }
}
