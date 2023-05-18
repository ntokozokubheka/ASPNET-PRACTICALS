using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace prac07_serviceB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool register(string email, string password, string user_type);
        [OperationContract]
        User login(string email, string password);
        [OperationContract]
        List<Product> getProducts();
        [OperationContract]
        Product getProduct(int id);
        [OperationContract]
        bool addProduct(string name, string description, string category, double price, string status, string img);
        [OperationContract]
        bool orderProduct(int user_id, int product_id, int quantity);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
