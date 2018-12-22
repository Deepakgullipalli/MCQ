using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ.MCQ
{
    class Que14
    {
        public void Que14Main()
        {
            int i = 5;
            int j = 6;
            calc(ref i);
            calc(6);
            Console.WriteLine(i);
            Console.ReadLine();
        }
        static void calc(ref int x)
        {
            x = x * x;
        }
        static void calc(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
}
