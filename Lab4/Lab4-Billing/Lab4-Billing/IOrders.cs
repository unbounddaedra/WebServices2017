using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab4_Billing
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrders
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        double GetNumberOfOrders();

        [OperationContract]
        double GetTotalCostForAnOrder(int OrderID);

        [OperationContract]
        ItemInformation[] GetItemListForOrder(int OrderID);

        [OperationContract]
        string HowManyOrderedForAPartNo(string sPartNo);

        [OperationContract]
        BillingInformation GetBillingAddressForAnOrder(int OrderID);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

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
    public class BillingInformation
    {
        [DataMember]
        public string fName;
        [DataMember]
        public string address;
        [DataMember]
        public string city;
        [DataMember]
        public string state;
        [DataMember]
        public string zip;
    }

    [DataContract]
    public class ItemInformation
    {
        [DataMember]
       public string partNo;
        [DataMember]
        public string desc;
        [DataMember]
        public string unitPrice;
        [DataMember]
        public string qty;
        [DataMember]
        public string totalCost;
        [DataMember]
        public string size;
        [DataMember]
        public string color;

    }
}
