using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWebService
{
    [ServiceContract]
    public interface IWebService
    {
        [OperationContract]
        int Factorial(int value);
    }
}
