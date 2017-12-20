<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderReceipt.aspx.cs" Inherits="OrderReceipt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentMenu">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Main.aspx">Home</asp:HyperLink>
    </div>
    <div>
        <br />
    </div>
    <div class="row">
        <div class="col-sm-12">
            <h3>Mailing Address</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <asp:Label ID="Addresslb" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="Addresstb" runat="server"></asp:TextBox>
        </div>
    </div>
    <div>
        <br />
    </div>
    <div class="row">
        <div class="col-sm-6">
            <asp:Label ID="StateCitylb" runat="server" Text="State/City:"></asp:Label>
            <asp:TextBox ID="StateCitytb" runat="server"></asp:TextBox>
        </div>
        <div class="col-sm-6">
            <asp:Label ID="Countrylb" runat="server" Text="Country:"></asp:Label>
            <asp:TextBox ID="Countrytb" runat="server"></asp:TextBox>
        </div>
    </div>
    <div>
        <br />
    </div>
    <div class="row">
        <div class="col-sm-4">
            <asp:Label ID="ZipCodelb" runat="server" Text="Zip/Postal Code:"></asp:Label>
            <asp:TextBox ID="ZipCodetb" runat="server"></asp:TextBox>
        </div>
    </div>
   
    <div>
        <br />
    </div>
    <div class="row">
        <div class="col-sm-12">
            <asp:Panel ID="Panel1" runat="server">
                <h3>Checkout Summary</h3>
                <asp:GridView ID="GridView1" Width="100%" runat="server" AutoGenerateColumns="False" ItemType="CartItem">
                    <Columns>
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right">
                            <HeaderStyle HorizontalAlign="Right" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>

                    </Columns>
                </asp:GridView>
                <asp:Button ID="PurchaseBtn" runat="server" Text="Purchase" OnClick="PurchaseBtn_Click" CssClass="moButton moButton2" />
                <asp:Label ID="failurelb" runat="server" Text=""></asp:Label>
            </asp:Panel>
        </div>
    </div>
</asp:Content>

