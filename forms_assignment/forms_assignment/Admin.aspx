<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" />
            <asp:TemplateField HeaderText="PartNumber" SortExpression="PartNumberPK">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("PartNumberPK") %>' Width="80px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("PartNumberPK") %>'  Width="60px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Description" SortExpression="Description">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Description") %>' Width="100px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="QtyOnHand" SortExpression="QtyOnHand">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("QtyOnHand") %>' Width="30px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("QtyOnHand") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Price" SortExpression="Price">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Price") %>' Width="52px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="FileName" HeaderText="FileName" SortExpression="FileName" />
        </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#330099" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <SortedAscendingCellStyle BackColor="#FEFCEB" />
    <SortedAscendingHeaderStyle BackColor="#AF0101" />
    <SortedDescendingCellStyle BackColor="#F6F0C0" />
    <SortedDescendingHeaderStyle BackColor="#7E0000" />
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:rlee_F14ConnectionString %>" InsertCommand="INSERT INTO [tblInventory] ([PartNumberPK], [Description], [QtyOnHand], [Price], [FileName]) 
VALUES (@PartNumberPK, @Description, @QtyOnHand, @Price, @FileName)" OldValuesParameterFormatString="original_{0}" 
SelectCommand="SELECT * FROM [tblInventory]"  DeleteCommand="DELETE FROM [tblInventory] WHERE [PartNumberPK] = @original_PartNumberPK" UpdateCommand="UPDATE [tblInventory] SET [Description] = 
@Description, [QtyOnHand] = @QtyOnHand, [Price] = @Price, [FileName] = @FileName WHERE [PartNumberPK] = 
@original_PartNumberPK AND (([Description] = @original_Description) OR ([Description] IS NULL AND 
@original_Description IS NULL)) AND (([QtyOnHand] = @original_QtyOnHand) OR ([QtyOnHand] IS NULL 
AND @original_QtyOnHand IS NULL)) AND (([Price] = @original_Price) OR ([Price] IS NULL AND @original_Price IS NULL)) 
AND (([FileName] = @original_FileName) OR ([FileName] IS NULL AND @original_FileName IS NULL))">
         <InsertParameters>
            <asp:Parameter Name="PartNumberPK" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="QtyOnHand" Type="Int32" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="FileName" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rlee_F14ConnectionString2 %>" SelectCommand="SELECT * FROM [tblInventory]"></asp:SqlDataSource>
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Item" style="margin-right: 20px" />
&nbsp;<div id="add_data" runat="server">
        <p style="float: left; width: 100%;"><asp:Label ID="lblPartno" runat="server" Text="Part Number" Width="7em"></asp:Label><asp:TextBox ID="txtPart" runat="server"></asp:TextBox><br /></p>
        <p style="float: left; width: 100%;"><asp:Label ID="lbldesc" runat="server" Text="Description" Width="7em"></asp:Label><asp:TextBox ID="txtDesc" runat="server"></asp:TextBox></p>
        <p style="float: left; width: 100%;"><asp:Label ID="lblQty" runat="server" Text="QtyOnHAnd" Width="7em"></asp:Label><asp:TextBox ID="txtQty" runat="server"></asp:TextBox></p>
        <p style="float: left; width: 100%;"><asp:Label ID="lblPrice0" runat="server" Text="Price" Width="7em"></asp:Label><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></p>
        <p style="float: left; width: 100%;"><asp:Label ID="lblFile" runat="server" Text="FileName" Width="7em"></asp:Label><asp:TextBox ID="txtFile" runat="server"></asp:TextBox></p>
        <p style="float: left; width: 100%;"><asp:Button ID="btnInsert" runat="server" Text="Insert to DB" OnClick="btnUpdate_Click"  /></p>
        <table class="nav-justified">
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

</asp:Content>

