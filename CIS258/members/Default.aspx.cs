using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ClassLibrary.Class1 myclass = new ClassLibrary.Class1();
        myclass.Name = txtName.Text;
        myclass.Address = txtAddress.Text;
        myclass.City = txtCity.Text;
        myclass.State = txtState.Text;
        myclass.Zip = txtZip.Text;

        Response.Redirect("about.aspx");
    }
    
    
}