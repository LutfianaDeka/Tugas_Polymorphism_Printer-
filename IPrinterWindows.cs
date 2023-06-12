using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public interface IPrinterWindows
    {
        void Show()
        {
            Console.WriteLine("Printer display dimension: ");
        }
        void Print() 
        {
            Console.WriteLine("Printer printing ....");
        }
    }
}
