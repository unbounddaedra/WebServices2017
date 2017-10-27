using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml.XPath;

namespace Lab4_Billing
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Lab4Billing : IOrders
    {
        public BillingInformation GetBillingAddressForAnOrder(int OrderID)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }



        public double GetNumberOfOrders()
        {
            XPathNavigator nav;
            XPathNavigator custNav;
            XPathDocument docNav;
            XPathNodeIterator NodeIterBilling;
            XPathNodeIterator NodeIterShipping;
            XPathNodeIterator NodeIterItems;
            XPathNodeIterator NodeIterCustOpt;



            String rootPath = HttpContext.Current.Server.MapPath(".");
            string strFilename = rootPath + "\\Orders.xml";

            docNav = new XPathDocument(strFilename);

            nav = docNav.CreateNavigator();

            //  string orderInfo = "/OrderFeed/Order";

            //  NodeIterBilling = nav.Select(orderInfo);

            double item1 = (double)
                nav.Evaluate("count(/OrderFeed/Order)");
            return item1;


        }

        public double GetTotalCostForAnOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathNavigator custNav;
            XPathDocument docNav;
            XPathNodeIterator NodeIterBilling;
            XPathNodeIterator NodeIterShipping;
            XPathNodeIterator NodeIterItems;
            XPathNodeIterator NodeIterCustOpt;



            String rootPath = HttpContext.Current.Server.MapPath(".");
            string strFilename = rootPath + "\\Orders.xml";

            docNav = new XPathDocument(strFilename);

            nav = docNav.CreateNavigator();

            double item1 = (double)
            nav.Evaluate("sum(OrderFeed/Order[@id =" + OrderID + "]/Items/Item/TotalCost)");
            return item1;
        }

        public string HowManyOrderedForAPartNo(string sPartNo)
        {
            throw new NotImplementedException();
        }

        ItemInformation[] IOrders.GetItemListForOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathNavigator custNav;
            XPathDocument docNav;
            XPathNodeIterator NodeIterBilling;
            XPathNodeIterator NodeIterShipping;
            XPathNodeIterator NodeIterItems;
            XPathNodeIterator NodeIterCustOpt;



            String rootPath = HttpContext.Current.Server.MapPath(".");
            string strFilename = rootPath + "\\Orders.xml";

            int counter = 0;

            docNav = new XPathDocument(strFilename);

            nav = docNav.CreateNavigator();

            // ItemInformation newItem = new ItemInformation();

            ItemInformation[] noItems = new ItemInformation[5];
           

            string search = "/OrderFeed/Order[@id =" + OrderID + "]/Items/Item";

            string options = "/OrderFeed/Order[@id =" + OrderID + "]/Items/Item/CustomerOptions";

            NodeIterItems = nav.Select(search);

            NodeIterCustOpt = nav.Select(options);

            while (NodeIterItems.MoveNext())
            {
                ItemInformation items = new ItemInformation();

                items.partNo = (NodeIterItems.Current.SelectSingleNode("PartNo").Value);



                items.desc = (NodeIterItems.Current.SelectSingleNode("Description").Value);



                items.unitPrice = (NodeIterItems.Current.SelectSingleNode("UnitPrice").Value);



                items.qty = (NodeIterItems.Current.SelectSingleNode("Quantity").Value);



                items.totalCost =(NodeIterItems.Current.SelectSingleNode("TotalCost").Value);



                while (NodeIterCustOpt.MoveNext())
                {
                    custNav = NodeIterCustOpt.Current;

                    int i = NodeIterCustOpt.Current.SelectChildren(XPathNodeType.Element).Count;

                    if (i > 0)
                    {
                        items.size = (custNav.SelectSingleNode("Size").Value);

                        items.color = (custNav.SelectSingleNode("Color").Value);
                    }
                }

                noItems[counter] = items;
                counter++;

            }

            return noItems;
        }
    }
}
