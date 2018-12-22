using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ.MCQ
{
    public class Que1
    {
        public void Que1Main()
        {
            sample s = new sample();
            sample.func1();
            s.func2(20);
            Console.ReadLine();
        }
    }

    public class sample
    {
        public static void func1()
        {
            Console.WriteLine("Printing func1");
        }
        public void func2()
        {
            func1();
            Console.WriteLine("Printing func2");
        }
        public void func2(int k)
        {
            Console.WriteLine(k);
        }
    }
}
