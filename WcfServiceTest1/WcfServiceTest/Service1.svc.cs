using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private static List<contract_type> Yyy;

        public Service1()
        {
            Yyy = new List<contract_type>()
            {
                new contract_type(123, 1000, "Valvar1","1234","Silver"),
                new contract_type(231, 3000, "Valvar2","2345","Gold"),
                new contract_type(321, 5000, "Valvar3","3456","Platinum")
            };
        }

        public List<contract_type> getAll()
        {
                return Yyy;
        }

        public contract_type getById(string Id)
        {
            int intId = int.Parse(Id);
            contract_type check = Yyy.Find(b => b.Id == intId);
            return check;
        }

        public string update(string Id, contract_type item)
        {
            if (item == null)
                throw new ArgumentNullException("Update error");
            int idx = Yyy.FindIndex(b => b.Id == item.Id);
            if (idx == -1)
                return "Impossible to update item of id=" + Id;
            Yyy.RemoveAt(idx);
            Yyy.Add(item);
            return "Updated item of id=" + Id;
        }

        public List<contract_type> getJsonAll()
        {
            return Yyy;
        }

        public contract_type getJsonById(string Id)
        {
            int intId = int.Parse(Id);
            contract_type check = Yyy.Find(b => b.Id == intId);
            return check;
        }

        public string updateJson(string Id, contract_type item)
        {
            if (item == null)
                throw new ArgumentNullException("Update error");
            int idx = Yyy.FindIndex(b => b.Id == item.Id);
            if (idx == -1)
                return "Impossible to update item of id=" + Id;
            Yyy.RemoveAt(idx);
            Yyy.Add(item);
            return "Updated item of id=" + Id;
        }
    }
}
