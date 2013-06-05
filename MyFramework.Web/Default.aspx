<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MyFramework.Web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        <br />
        增加一个水果:</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="分类名:"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="水果名:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" Text="增加" onclick="Button1_Click" /><br />
    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
