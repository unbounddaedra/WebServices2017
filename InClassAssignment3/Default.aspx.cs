using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;


public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XPathNavigator nav;
        XPathDocument docNav;
        XPathNodeIterator NodeIter;
        String rootPath = Server.MapPath("~");
        string strFilename = rootPath + "\\ContactManager.xml";
        docNav = new XPathDocument(strFilename);

        // Create a navigator to query with XPath.
        nav = docNav.CreateNavigator();
        String searchString = "";

        // you need to determine the proper XPath statement

        // Select the node and place the results in an iterator.
        NodeIter = nav.Select(searchString);

        while (NodeIter.MoveNext())

    }
}