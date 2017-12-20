<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserRegistration.aspx.cs" Inherits="UserRegisteration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentMenu">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Main.aspx">Home</asp:HyperLink>
        <span>>Register</span>
    </div>
    <h3>Team5 Book Store Registration</h3>

    <div class="col-md-6">
        <div class="form-group">
            <asp:Label runat="server" Text="User Name:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="User Name cannot be empty" ControlToValidate="txtUserName" ValidationGroup="valGroup">*Required</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Password cannot be empty" ControlToValidate="txtPassword" ValidationGroup="valGroup">*Required</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Re-enter password: "></asp:Label>
            <asp:TextBox ID="txtPasswordConfirmation" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
            <asp:CompareValidator runat="server" ErrorMessage="The passwords do not match" ControlToCompare="txtPassword" ControlToValidate="txtPasswordConfirmation" ValidationGroup="valGroup"></asp:CompareValidator>
        </div>
        <asp:Button runat="server" Text="Sign Up" OnClick="Unnamed7_Click" ValidationGroup="valGroup" CssClass="moButton moButton2" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

