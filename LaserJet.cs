using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 10cm * 11cm");
        }

        public void Print()
        {
            Console.WriteLine("Laseret printer printing ....");
        }
    }
}
