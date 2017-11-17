using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExceptionExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MathException : IMathException
    {
        public string DivisionExample(int numerator, int denominator)
        {
            float result = 0;
            try
            {

                result = numerator / denominator;
                
            }
            catch (DivideByZeroException)
            {

                Console.Out.WriteLine("You cannot divide by zero");
            }
           return result.ToString();
        }


        public string FormattingError(string Number)
        {

            return Convert.ToSingle(Number).ToString();


        }
        public string DivisionExampleSoapMessage(int numerator, int denominator)
        {
            float result = numerator / denominator;
            return result.ToString();

        }


        public string FormattingErrorSoapMessage(string Number)
        {

            return Convert.ToSingle(Number).ToString();

        }
    }
}
