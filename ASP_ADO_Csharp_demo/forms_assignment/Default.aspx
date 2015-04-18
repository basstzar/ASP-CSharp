<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

   
    <table class="nav-justified">
        <tr>
            <td style="width: 403px">
                <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Shop Now!" Width="99px" CausesValidation="False" />
            </td>
            <td style="width: 484px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px; height: 22px;">
            </td>
            <td style="width: 484px; height: 22px;">
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label1" runat="server" Text="First Name" Width="5em"></asp:Label>
                <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirst" ErrorMessage="First name required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td style="width: 484px">
                <asp:Label ID="Label2" runat="server" Text="Last Name" Width="5em"></asp:Label>
                <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLast" ErrorMessage="Last name is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label3" runat="server" Text="Address" Width="5em"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td style="width: 484px">
                <asp:Label ID="Label4" runat="server" Text="City" Width="5em"></asp:Label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" ErrorMessage="City is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label5" runat="server" Text="State" Width="5em"></asp:Label>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtState" ErrorMessage="State is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td style="width: 484px">
                <asp:Label ID="Label6" runat="server" Text="Zip" Width="5em"></asp:Label>
                <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtZip" ErrorMessage="Zipcode is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtZip" ErrorMessage="Enter a valid zipcode" ForeColor="#CC0000" ValidationExpression="\d{5}(-\d{4})?">*</asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Label ID="Label7" runat="server" Text="Phone" Width="5em"></asp:Label>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                <br />
                <table class="nav-justified">
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text="CC" Width="5em"></asp:Label>
                <asp:TextBox ID="txtCredit" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCredit" ErrorMessage="Not A Valid Card Number" ValidationExpression="\b(?:3[47]\d|(?:4\d|5[1-5]|65)\d{2}|6011)\d{12}\b"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtCredit" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 484px">
                <asp:Label ID="Label8" runat="server" Text="Type Member" Width="7em"></asp:Label>
                <asp:DropDownList ID="cboMember" runat="server" DataSourceID="SqlDataSource2" DataTextField="TypeMember" DataValueField="TypeMember">
                    <asp:ListItem>Select One</asp:ListItem>
                    <asp:ListItem>Regular</asp:ListItem>
                    <asp:ListItem>Life</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DemoGuestConnectionString %>" SelectCommand="SELECT * FROM [TypeMember]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rlee_F14ConnectionString %>" SelectCommand="SELECT * FROM [tblInventory]"></asp:SqlDataSource>
                &nbsp;<asp:Label ID="Label9" runat="server" Text="Type Member (Unbound)"></asp:Label>
                <asp:DropDownList ID="cboAdo" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="cboMember" ErrorMessage="Must select one" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
            </td>
            <td style="width: 484px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </td>
            <td style="width: 484px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">&nbsp;</td>
            <td style="width: 484px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 403px">&nbsp;</td>
            <td style="width: 484px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource2" />
   
    <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/ads.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
   
</asp:Content>
