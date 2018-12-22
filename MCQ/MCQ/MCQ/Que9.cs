using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ.MCQ
{
    delegate void Printer();
    class Que9
    {
        public void Que9Main()
        {
            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 5; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }
            foreach (var printer in printers)
            {
                printer();
            }
        }
    }
}
