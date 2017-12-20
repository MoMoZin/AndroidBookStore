<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDetail.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="Content/StyleSheet.css" rel="stylesheet" />
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <div class ="row"><br /></div>
                <asp:Image ID="Image2"  runat="server" ImageUrl="image" cssclass="moButton moButton2" />
            </div>
            <div class="col-md-8">
                <div class ="row"><br /></div>
                <div class="row">
                    <div class="col-md-3">Title:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblTitle" runat="server" Text="label"></asp:Label>
                    </div>
                </div>
                <div class ="row"><br /></div>
                <div class="row">
                    <div class="col-md-3">Category:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblCat" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class ="row"><br /></div>
                <div class="row">
                    <div class="col-md-3">ISBN:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblISBN" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class ="row"><br /></div>
                <div class="row">
                    <div class="col-md-3">Author:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblAuthor" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class ="row"><br /></div>
                <div class="row">
                    <div class="col-md-3">Price:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class ="row"><br /></div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
                    </div>
                    <div class="col-md-3">
                        <input type="number" id="qty" runat="server" min="1" value="1" />
                    </div>
                    <div class="col-md-3">
                     <asp:Label ID="Label1" runat="server" Text="" ForeColor="#CC3300" Font-Bold="True"></asp:Label>
                    </div>
                </div>
                <div class ="row"><br /></div>   
                <div class="row">
                    <div class="col-md-3">
                        <asp:Button ID="BtnAddToCart" runat="server" Text="Add To Cart" OnClick="BtnAddToCart_Click1" CssClass="moButton moButton2" />
                    </div>
                </div>                
            </div>
        </div>
    </div>
</asp:Content>

