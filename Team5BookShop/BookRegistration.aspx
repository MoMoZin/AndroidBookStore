<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookRegistration.aspx.cs" Inherits="BookRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server" >    
    <link href="Content/StyleSheet.css" rel="stylesheet" />
    <div class="container bookRegister">

        <div class="row">            
            <div class="col-md-2">                
                Image Upload: 
            </div>
            <div class="col-md-10">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Invalid Image Type" ForeColor="Red" ValidationExpression="^([0-9a-zA-Z_\-~ :\\])+(.jpg|.JPG|.jpeg|.JPEG|.bmp|.BMP|.gif|.GIF|.png|.PNG)$"></asp:RegularExpressionValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-2">
                ISBN: 
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtISBN" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtISBN" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ValidationGroup="BookRegisterValidate"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Category:
            </div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlistCat" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Title:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtTitle" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtTitle" ValidationGroup="BookRegisterValidate"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Author:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtAuthor" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtAuthor" ValidationGroup="BookRegisterValidate"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Price:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtPrice" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtPrice" ValidationGroup="BookRegisterValidate"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPrice" ErrorMessage="Please enter an amount in the correct format" ForeColor="Red" ValidationExpression="^\d+([,\.]\d{1,2})?$" ValidationGroup="BookRegisterValidate"></asp:RegularExpressionValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-2">
                Book Stock:
            </div>
            <div class="col-md-10">
                <input type="number" id="bookStock" runat="server" min="1" class="auto-style1" value="1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblStock" runat="server" ForeColor="Red"></asp:Label>
                </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-2">
                Discount Code:
            </div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlDiscount" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-12 moButton moButton2">
                <asp:Button ID="btnAdd" runat="server" Text="Submit" OnClick="btnAdd_Click" class="moButton moButton2" ValidationGroup="BookRegisterValidate" />
            </div>  
            <div class="col-md-12"          >
                <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>

