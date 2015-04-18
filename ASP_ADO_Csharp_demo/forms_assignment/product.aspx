<%@ Page Language="C#" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="624px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />

                <asp:BoundField DataField="PartNumberPK" HeaderText="PartNumberPK" SortExpression="PartNumberPK" >
                </asp:BoundField>
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description">
                </asp:BoundField>
                <asp:BoundField DataField="QtyOnHand" HeaderText="QtyOnHand" SortExpression="QtyOnHand">
                </asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price">
                </asp:BoundField>
               
                
               
                <asp:ButtonField CommandName="Remove" Text="Remove" />
               
                
               
                <asp:ImageField DataImageUrlField="FileName" DataImageUrlFormatString="~/images/{0}">
                </asp:ImageField>
               
                
               
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
            
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:rlee_F14ConnectionString %>" SelectCommand="SELECT * FROM [tblInventory]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=134.39.173.35;Initial Catalog=DemoGuest;Persist Security Info=True;User ID=demoguest;Password=Sp0kan3" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [PartNumberPK], [Description], [QtyOnHand], [Price], [FileName] FROM [tblInventory]"></asp:SqlDataSource>
    
            
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
         <div id="products" runat="server">
        </div>

    </div>
    </form>
</body>
</html>
