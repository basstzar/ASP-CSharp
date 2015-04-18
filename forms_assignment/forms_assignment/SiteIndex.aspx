<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SiteIndex.aspx.cs" Inherits="SiteIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <asp:SiteMapDataSource ID="MySiteMapDataSource" runat="server" />
        <asp:TreeView ID="MyTreeView" runat="server" DataSourceID="MySiteMapDataSource" ShowLines="true" />
    </div>
</asp:Content>

