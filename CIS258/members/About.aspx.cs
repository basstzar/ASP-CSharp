using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClassLibrary.Class1 myclass = new ClassLibrary.Class1();

        Label1.Text = myclass.Name;
    }
   
}