<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchCategoryResult.aspx.cs" Inherits="SearchCategoryResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="contentMenu">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Main.aspx">Home</asp:HyperLink> 
        <span>><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Main.aspx">Categories</asp:HyperLink>
            ><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span>
    </div>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>

