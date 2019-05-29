using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWebService
{
        public class Service1 : IWebService
        {
            public int Factorial(int value)
            {
                int result = 1;
                for (int i = 1; i <= value; i++)
                    result *= i;
                return result;
            }
        }
}
