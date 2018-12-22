using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ.MCQ
{
    class Que21
    {
        public void Que21Main()
        {
            List<IPerson> p = new List<IPerson>();
            p.Add(new Student());
        }
    }
    public interface IPerson
    {

    }

    public class Employee: IPerson
    {

    }
    public class Student : Employee
    {

    }
}

