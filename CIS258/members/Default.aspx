<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
        <tr>
            <td style="width: 268px">
                <asp:Label ID="Label1" runat="server" Text="Name" Width="5em"></asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td style="width: 218px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 268px">
                <asp:Label ID="Label2" runat="server" Text="Address" Width="5em"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
            <td style="width: 218px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 268px">
                <asp:Label ID="Label3" runat="server" Text="City" Width="5em"></asp:Label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
            <td style="width: 218px">
                <asp:Label ID="Label6" runat="server" Text="State" Width="5em"></asp:Label>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Zip" Width="5em"></asp:Label>
                <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 268px">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </td>
            <td style="width: 218px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
