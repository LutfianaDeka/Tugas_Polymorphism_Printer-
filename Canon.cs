using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension : 12cm * 13cm");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing ....");
        }
    }
}
