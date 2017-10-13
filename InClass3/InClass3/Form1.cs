using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;


namespace InClass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            String strExpression;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\Contacts.xml";
            StringBuilder results = new StringBuilder();
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // String searchString;
            lblVersionNum.Text = nav.SelectSingleNode("/ContactsList/VersionNumber").Value;
            lblVersionDate.Text = nav.SelectSingleNode("/ContactsList/VersionDate").Value;

            // Find the average cost of a book.
            // This expression uses standard XPath syntax.
            //strExpression = txtVersionNum.Text;

            // Use the Evaluate method to return the evaluated expression.
            //lblVersionNum.Text = nav.Evaluate(strExpression).ToString();
        }

        private void btnContactInfo_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\Contacts.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            String searchString = "/ContactsList/Contact";

            // you need to determine the proper XPath statement

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(searchString);

            while (NodeIter.MoveNext())
            {
                results.Append("First Name: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("FirstName").Value);

                results.Append("Last Name: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("LastName").Value);

                results.Append("Phone Number: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("PhoneNumber").Value);

                results.Append("Fax Number: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("FaxNumber").Value);

                results.Append("Email Address: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("EmailAddress").Value);
            }

            txtDisplay.Text = results.ToString();


        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\Contacts.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            String searchString = "/ContactsList/Contact[@gender=\"M\"]";

            // you need to determine the proper XPath statement

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(searchString);

            while (NodeIter.MoveNext())
            {
                results.Append("First Name: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("FirstName").Value);

                results.Append("Last Name: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("LastName").Value);

                results.Append("Phone Number: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("PhoneNumber").Value);

                results.Append("Fax Number: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("FaxNumber").Value);

                results.Append("Email Address: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("EmailAddress").Value);
            }

            txtDisplay.Text = results.ToString();
        }

        private void btnSearchLastName_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\Contacts.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
           // String searchString = "/ContactsList/Contact[LastName='" + txtLastName.Text + ]";
              String searchString = "/ContactsList/Contact[starts-with(LastName, ")]

            // you need to determine the proper XPath statement

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(searchString);

            while (NodeIter.MoveNext())
            {
                results.Append("First Name: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("FirstName").Value);

                results.Append("Last Name: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("LastName").Value);

                results.Append("Phone Number: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("PhoneNumber").Value);

                results.Append("Fax Number: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("FaxNumber").Value);

                results.Append("Email Address: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("EmailAddress").Value);
            }

            txtDisplay.Text = results.ToString();
        }
    }
    }
}

