<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookUpdate.aspx.cs" Inherits="BookUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <style>
        .errorAlert {
            font: bold;
            color: red;
        }
        .auto-style1 {
            width: 200px;
        }
    </style>
    <div class="container bookRegister">
        <div class="row">
            <div class="col-md-12">
                <asp:Image ID="Image2" runat="server" />
                <br />
            </div>
            <div class="col-md-4">
                ISBN: 
            </div>
            <div class="col-md-8">
                <asp:TextBox ID="txtISBN" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtISBN" ErrorMessage="Value cannot be empty" CssClass="errorAlert"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-4">
                Book Category:
            </div>
            <div class="col-md-8">
                <asp:DropDownList ID="ddlistCat" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-4">
                Book Title:
            </div>
            <div class="col-md-8">
                <asp:TextBox ID="txtTitle" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-4">
                Author:
            </div>
            <div class="col-md-8">
                <asp:TextBox ID="txtAuthor" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtAuthor"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-4">
                Book Price:
            </div>
            <div class="col-md-8">
                <asp:TextBox ID="txtPrice" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtPrice"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPrice" ErrorMessage="Please enter an amount in the correct format" ForeColor="Red" ValidationExpression="^\d+([,\.]\d{1,2})?$"></asp:RegularExpressionValidator>

            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-4">
                Book Stock:
            </div>
            <div class="col-md-8">
                <input type="number" id="bookStock" runat="server" min="0" class="auto-style1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblStock" runat="server" ForeColor="Red"></asp:Label>
                </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-4">
                Discount Code:
            </div>
            <div class="col-md-8">
                <asp:DropDownList ID="ddlDiscount" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-12 bookRegister">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="moButton moButton2" /> &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="moButton moButton2" />
            </div>   
        </div>
    </div>

</asp:Content>

