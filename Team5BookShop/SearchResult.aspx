<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchResult.aspx.cs" Inherits="SearchResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="contentMenu">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Main.aspx">Home</asp:HyperLink> 
        <span>>Search Result</span>
    </div>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>

