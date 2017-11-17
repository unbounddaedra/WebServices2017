using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace midtermProblem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            String strExpression;

            string xmlFile = Application.StartupPath + "\\catalog.xml";
            StringBuilder results = new StringBuilder();
           
            docNav = new XPathDocument(xmlFile);

            nav = docNav.CreateNavigator();

            String priceSort = "/catalog/product/catalog_item[price < 40]";

            NodeIter = nav.Select(priceSort);

            while (NodeIter.MoveNext())
            {
                results.Append("Product Name ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("item_number").Value);

                results.AppendLine("\r\n");

                results.Append("Price: ");
                results.AppendLine(NodeIter.Current.SelectSingleNode("price").Value);

                
               
            }

            txtOutPut.Text = results.ToString();

            
            String size = "//catalog/product/catalog_item/size[@description=\"Small\"]";

            NodeIter = nav.Select(size);

            while (NodeIter.MoveNext())
            {
                XPathNavigator item1 = NodeIter.Current;
                results.Append("Product Name ");
                results.AppendLine(item1.SelectSingleNode("item_number").Value);

               
            }

           

        }
    }
}
