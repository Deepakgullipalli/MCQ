using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ.MCQ
{
    class Que7
    {
        public void Que7Main()
        {

        }
    }
    class Que7A
    {
        public virtual void F()
        {
            Console.WriteLine("A.F");
        }
    }
    class Que7B : Que7A
    {
        new private void F()
        {
            Console.WriteLine("B.F");
        }
    }
    class Que7C : Que7B
    {
        public override void F()
        {
            Console.WriteLine("C.F");
        }
    }
    public class Que7D
    {
        public void F()
        {
            Console.WriteLine("D.F");
        }
    }
}
