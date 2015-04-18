using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;




public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        //Connection string.
        String cnStr;
        SqlConnection cn = new SqlConnection();

        cnStr =  "Data Source=134.39.173.35;Initial Catalog=DemoGuest;User ID=demoguest;Password=Sp0kan3";

        //Assign Connection string to the connection object
        cn.ConnectionString = cnStr;
        //Open the connection to the SQL Server
        cn.Open();



        //This statement creates the command object and passes in the SQL statement
        //then associates the command to the cn connection object
        SqlCommand cmd = new SqlCommand("select TypeMember from TypeMember", cn);

        //Open a DataReader
        SqlDataReader rdrZip = cmd.ExecuteReader();

        //Read record-by-record into the list box from the data reader
        //comboBox1.DataSource = rdrZip;

        while (rdrZip.Read())
        {
            String myString = rdrZip["TypeMember"].ToString().Trim();
           cboAdo.Items.Add(myString);

        }

        cn.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("product.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        member.member mymember = new member.member();

        mymember.first_name = txtFirst.Text;
        mymember.last_name = txtLast.Text;
        mymember.address = txtAddress.Text;
        mymember.city = txtCity.Text;
        mymember.state = txtState.Text;
        mymember.zip = txtZip.Text;
        mymember.phone = txtPhone.Text;
        mymember.type_member = cboMember.Text;
        mymember.unbound_member = cboAdo.Text;
        mymember.credit = txtCredit.Text;
     

        if (User.Identity.IsAuthenticated == true)
        {
            Session["member"] = mymember;

            Response.Redirect("Reciept.aspx");
        }
        else
        { Response.Redirect("Default.aspx"); }

        String cnStr;
        SqlConnection cn = new SqlConnection();

        cnStr = "Data Source=134.39.173.35;Initial Catalog=rlee_f14;User ID=rlee_f14;Password=zipzip";

        //Assign Connection string to the connection object
        cn.ConnectionString = cnStr;
        //Open the connection to the SQL Server
        cn.Open();



        SqlCommand cmd = new SqlCommand("insert into Members (namefirst, namelast,cc) values (@first,@last,@cc)", cn);
        cmd.Parameters.AddWithValue("@first", txtFirst.Text);
        cmd.Parameters.AddWithValue("@last", txtLast.Text);
        cmd.Parameters.AddWithValue("@cc", txtCredit.Text);
        
        cmd.ExecuteNonQuery();

        cn.Close();
    }


    protected void txtCredit_TextChanged(object sender, EventArgs e)
    {

    }
}