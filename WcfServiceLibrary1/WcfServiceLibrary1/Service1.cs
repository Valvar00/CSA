using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyCalculator : ICalculator
    {
        public ComplexNum addCNum(ComplexNum n1,ComplexNum n2)
        {
            Console.WriteLine("...called addCNum(...)");
            return new ComplexNum(n1.realPart + n2.realPart, n1.imagPart + n2.imagPart);
        }
        public void Function1(String s1)
        {
            Console.WriteLine("...{0}:  Function1  -  start", s1); Thread.Sleep(3000);
            Console.WriteLine("...{0}”  Function1  -  stop", s1);
            return;
        }
        public void Function2(String s2)
        {
            Console.WriteLine("...{0}:  Function2  -  start", s2); Thread.Sleep(3000);
            Console.WriteLine("...{0}:  Function2  -  stop", s2);
            return;
        }

    }
}
