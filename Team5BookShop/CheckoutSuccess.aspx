<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CheckoutSuccess.aspx.cs" Inherits="CheckoutSuccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-sm-12">
            <h3>Your purchase has been successfully logged. To return, please click <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Main.aspx">HERE</asp:HyperLink></h3>
        </div>
    </div>
</asp:Content>

