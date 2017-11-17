using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace midtermproblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest myHttpWebRequest = null;     
            HttpWebResponse myHttpWebResponse = null;   
            XmlTextReader myXMLReader = null;           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            string url = "http://34.229.220.156/BankingService/Bankservice.asmx/GetBankInformation";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            nav = docNav.CreateNavigator();
        
            
            string owner = "/BankInformation";
            NodeIter = nav.Select(owner);

            while (NodeIter.MoveNext())
            {
                Console.WriteLine(NodeIter.Current.SelectSingleNode("OwnerName"));
                Console.WriteLine(NodeIter.Current.SelectSingleNode("AccountID"));
                

            }
           
            
            


            double t = (double)
               nav.Evaluate("sum(BankInformation/accounts/AccountInfo/Amount)");

            Console.WriteLine(t);

            Console.ReadLine();
        }
    }
}
