using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactManager

{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContactManager
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        int GetNumberOfContacts(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        ContactInformation GetClientInformation();
        // TODO: Add your service operations here


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

    [DataContract]
    public class ContactInformation
    {
        [DataMember]
        public string firstName;
        [DataMember]
        public string lastName;
        [DataMember]
        public string phoneNum;
        [DataMember]
        public string faxNum;
        [DataMember]
        public string email;
    }
}
