using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension : 11cm * 12cm");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing ....");
        }
    }
}
