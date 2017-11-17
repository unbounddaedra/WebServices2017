using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExcptClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathException.MathExceptionClient proxy = new MathException.MathExceptionClient("BasicHttpBinding_IMathException");
            Console.WriteLine(proxy.DivisionExample(4, 2));
            Console.WriteLine(proxy.FormattingError("0"));
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
