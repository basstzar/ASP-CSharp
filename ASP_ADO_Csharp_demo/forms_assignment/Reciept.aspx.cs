using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        member.member mymember = new member.member();
        mymember = (member.member)Session["member"];
        txtFirst.Text = mymember.first_name;
        txtLast.Text = mymember.last_name;
        txtAddress.Text = mymember.address;
        txtCity.Text = mymember.city;
        txtState.Text = mymember.state;
        txtZip.Text = mymember.zip;
        txtMember.Text = mymember.type_member;
        txtUnbound.Text = mymember.unbound_member;
        txtCC.Text = mymember.credit;
      
        
        
        
    }
}