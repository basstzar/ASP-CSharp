<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reciept.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 601px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table class="nav-justified">
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label1" runat="server" Text="First Name" Width="5em"></asp:Label>
                <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Last Name" Width="5em"></asp:Label>
                <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label3" runat="server" Text="Address" Width="5em"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="City" Width="5em"></asp:Label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label5" runat="server" Text="State" Width="5em"></asp:Label>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Text="Zip" Width="5em"></asp:Label>
                <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label7" runat="server" Text="Phone" Width="5em"></asp:Label>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label8" runat="server" Text="Member" Width="5em"></asp:Label>
                <asp:TextBox ID="txtMember" runat="server"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Text="Member(unbound)" Width="8em"></asp:Label>
                <asp:TextBox ID="txtUnbound" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label10" runat="server" Text="CC" Width="5em"></asp:Label>
                <asp:TextBox ID="txtCC" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                &nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
