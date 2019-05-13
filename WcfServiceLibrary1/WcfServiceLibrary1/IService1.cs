using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        ComplexNum addCNum(ComplexNum n1,ComplexNum n2);
        [OperationContract]
        void Function1(String s1);
        [OperationContract(IsOneWay = true)]
        void Function2(String s2);
    }

    [DataContract]
    public class ComplexNum
    {
        string desc = "Complex NUmber";
        [DataMember]
        public double realPart;
        [DataMember]
        public double imagPart;
        [DataMember]
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public ComplexNum(double rp,double ip)
        {
            this.realPart = rp;
            this.imagPart = ip;
        }
    }
}
