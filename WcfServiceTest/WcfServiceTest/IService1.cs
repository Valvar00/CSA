using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Xxx/{id}")]
        List<contract_type> getAll();
        [OperationContract]
        [WebGet(UriTemplate = "/Xxx/{id}",
        ResponseFormat = WebMessageFormat.Xml)]
        contract_type getById(string Id);
        [OperationContract]
        [WebInvoke(UriTemplate = "/Xxx/{id}",
        Method = "PUT",
        RequestFormat = WebMessageFormat.Xml)]
        string update(string Id, contract_type item);



        [OperationContract]
        [WebGet(UriTemplate = "/json/Xxx/{id}",
        RequestFormat = WebMessageFormat.Json)]
        List<contract_type> getJsonAll();
        [OperationContract]
        [WebGet(UriTemplate = "/json/Xxx/{id}",
        ResponseFormat = WebMessageFormat.Json)]
        contract_type getJsonById(string Id);
        [OperationContract]
        [WebInvoke(UriTemplate = "/json/Xxx/{id}",
        Method = "PUT",
        RequestFormat = WebMessageFormat.Json)]
        string updateJson(string Id, contract_type item);
    }


    [DataContract]
    public class contract_type
    {
        [DataMember]
        public int Id;
        [DataMember]
        int balance;
        [DataMember]
        string Login;
        [DataMember]
        string Password;
        [DataMember]
        string Rank;
        public contract_type(int id_, int balance_, string Login_, string Password_,string Rank_)
        {
            Id = id_;
            balance = balance_;
            Login = Login_;
            Password = Password_;
            Rank = Rank_;
        }
    }
}
