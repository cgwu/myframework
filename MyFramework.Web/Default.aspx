<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MyFramework.Web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <p>
        <br />
        增加一个水果:</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate> 
    

       <p>
        <asp:Label ID="Label1" runat="server" Text="分类名:"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="水果名:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" Text="增加" onclick="Button1_Click" /><br />
    
    
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
