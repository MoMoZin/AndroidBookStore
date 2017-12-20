<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 468px;
            margin-top: 134px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentMenu">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Main.aspx">Home</asp:HyperLink>
        <span>>Login</span>
    </div>
    <h3>Welcome to Team5 Book Store</h3>
    <div class="col-md-6">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Enter User ID" for="TextBox1"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Enter Password" for="Password1"></asp:Label>&nbsp&nbsp
    <input id="Password1" type="password" runat="server" class="form-control" />
        </div>
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click" CssClass="moButton moButton2" />&nbsp
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UserRegistration.aspx">New Customer?</asp:HyperLink>

    </div>
</asp:Content>

