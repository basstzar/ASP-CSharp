using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class product : System.Web.UI.Page
{
    static List<string> aPartNo = new List<string>();
    static List<int> aQty = new List<int>();

    
    protected void Page_Load(object sender, EventArgs e)
    {
     
        member.member mymember = new member.member();
       
        //Connection string.
        String cnStr;
        SqlConnection cn = new SqlConnection();

        cnStr = "Data Source=134.39.173.35;Initial Catalog=rlee_f14;User ID=rlee_f14;Password=zipzip";

        //Assign Connection string to the connection object
        cn.ConnectionString = cnStr;
        //Open the connection to the SQL Server
        cn.Open();



        //This statement creates the command object and passes in the SQL statement
        //then associates the command to the cn connection object
        SqlCommand cmd = new SqlCommand("select Inventory from rlee_f14", cn);

       // if (User.Identity.IsAuthenticated == false)
       // { Response.Redirect("Account/Login"); }

        cn.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //GridViewRow myrow = GridView1.SelectedRow;
        //products.InnerHtml= "<h2>You ordered: Part no. " + myrow.Cells[2].Text +" "+"Description: "+ myrow.Cells[3].Text+"</h2>"; 
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
         

        int index = Convert.ToInt32(e.CommandArgument);
        GridViewRow myRow = GridView1.Rows[index];
              
        if (e.CommandName == "Remove")
        {
                        
            if (aPartNo.IndexOf(myRow.Cells[2].Text) == -1)
               
            {
            }
            else
            {
                int myindex = (aPartNo.IndexOf(myRow.Cells[2].Text));

                

                aQty[myindex] = aQty[myindex] - 1;
                String cnStr;
                SqlConnection cn = new SqlConnection();

                cnStr = "Data Source=134.39.173.35;Initial Catalog=rlee_f14;User ID=rlee_f14;Password=zipzip";

                //Assign Connection string to the connection object
                cn.ConnectionString = cnStr;
                //Open the connection to the SQL Server
                cn.Open();



                String strSQL;
                //strSQL = ("update tblInventory set QtyOnHand = QtyOnHand-1 where PartNumberPK ='" + myRow.Cells[1].Text + "'  ");
                SqlCommand cmd = new SqlCommand("update tblInventory set QtyOnHand = QtyOnHand+1 where PartNumberPK = @part", cn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@part";
                param.Value = myRow.Cells[1].Text;

                // 3. add new parameter to command object
                cmd.Parameters.Add(param);
                //SqlCommand cmdx = new SqlCommand(strSQL, cn);
                cmd.ExecuteNonQuery();

                myRow.Cells[3].Text = (int.Parse(myRow.Cells[3].Text) + 1).ToString();
                cn.Close();

                if (aQty[myindex] <= 0)
                {
                    aPartNo.RemoveAt(myindex);
                    aQty.RemoveAt(myindex);
                }
            }
        }
        else if (e.CommandName == "Select")
        {
            if (aPartNo.IndexOf(myRow.Cells[2].Text) == -1)
            {
                aPartNo.Add(myRow.Cells[2].Text);
                aQty.Add(1);
            }
            else
            {
                int myindex = (aPartNo.IndexOf(myRow.Cells[2].Text));
                aQty[myindex] = aQty[myindex] + 1;
            
                String cnStr;
                SqlConnection cn = new SqlConnection();

                cnStr = "Data Source=134.39.173.35;Initial Catalog=rlee_f14;User ID=rlee_f14;Password=zipzip";

                //Assign Connection string to the connection object
                cn.ConnectionString = cnStr;
                //Open the connection to the SQL Server
                cn.Open();
                

        
                String strSQL;
                //strSQL = ("update tblInventory set QtyOnHand = QtyOnHand-1 where PartNumberPK ='" + myRow.Cells[1].Text + "'  ");
                SqlCommand cmd = new SqlCommand("update tblInventory set QtyOnHand = QtyOnHand-1 where PartNumberPK = @part", cn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@part";
                param.Value = myRow.Cells[1].Text;

                // 3. add new parameter to command object
                cmd.Parameters.Add(param);
                //SqlCommand cmdx = new SqlCommand(strSQL, cn);
                cmd.ExecuteNonQuery();
                
                myRow.Cells[3].Text = (int.Parse(myRow.Cells[3].Text) - 1).ToString();
                cn.Close();
            }
            
        }
        string myLine;
        products.InnerHtml = "";
        for (int i = 0; i < aPartNo.Count; i++)
        {

            myLine = "<h2>" + aPartNo[i] + "- Qty" + aQty[i].ToString() + "</h2>";
            products.InnerHtml = products.InnerHtml + myLine;
        }
    }
   
}