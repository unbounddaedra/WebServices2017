﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExceptionExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMathException
    {

        [OperationContract]
        string DivisionExample(int numerator, int denominator);

        [OperationContract]
        string FormattingError(string Number);

        [OperationContract]
        string DivisionExampleSoapMessage(int numerator, int denominator);

        [OperationContract]
        string FormattingErrorSoapMessage(string Number);

        // TODO: Add your service operations here
        // TODO: Add your service operations here
    }


    
}
