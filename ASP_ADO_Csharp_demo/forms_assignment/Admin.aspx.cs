using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole("ADMIN"))
        { Response.Redirect("Account/Login"); } 
        add_data.Visible = false;
        
        

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        add_data.Visible = true;

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        String cnStr;
        SqlConnection cn = new SqlConnection();

        cnStr = "Data Source=134.39.173.35;Initial Catalog=rlee_f14;User ID=rlee_f14;Password=zipzip";

        //Assign Connection string to the connection object
        cn.ConnectionString = cnStr;
        //Open the connection to the SQL Server
        cn.Open();




        SqlCommand cmd = new SqlCommand("insert into tblInventory (PartNumberPK,Description,QtyOnHand,Price,FileName) values (@part, @desc, @qty, @price, @file)",cn);
        cmd.Parameters.AddWithValue("@part", txtPart.Text);
        cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
        cmd.Parameters.AddWithValue("@qty", txtQty.Text);
        cmd.Parameters.AddWithValue("@price", txtPrice.Text);
        cmd.Parameters.AddWithValue("@file", txtFile.Text);
        cmd.ExecuteNonQuery();

        cn.Close();
    }
   

    
   
}