using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Lab1pt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parseContactInfo_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\Contacts.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList contacts = xmlDoc.GetElementsByTagName("Contact");
            XmlNodeList contactslist = xmlDoc.GetElementsByTagName("ContactsList");
            

            foreach (XmlNode node in contactslist)
            {
                string version = node["VersionNumber"].InnerText;
                Console.WriteLine(version);
                results.AppendLine("Version Number: " + version);
            }
            
            
            foreach (XmlNode node in contacts)
            {
               
                string fname = node["FirstName"].InnerText;
                string lname = node["LastName"].InnerText;
                string pnum = node["PhoneNumber"].InnerText;
                string fnum = node["FaxNumber"].InnerText;
                string email = node["EmailAddress"].InnerText;
                


                Console.WriteLine(fname);
                Console.WriteLine(lname);
                Console.WriteLine(pnum);
                Console.WriteLine(fnum);
                Console.WriteLine(email);
                results.AppendLine(fname);
                results.AppendLine(lname);
                results.AppendLine(pnum);
                results.AppendLine(fnum);
                results.AppendLine(email);

                results.AppendLine(Environment.NewLine); 
            }

            
            txtResults.Text = results.ToString();

        }
    }
 }

