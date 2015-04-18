using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Temp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Roles.CreateRole("ADMIN");
        Roles.AddUserToRole("Teacher","ADMIN");
        //Roles.IsUserInRole("ADMIN") 
    }
}