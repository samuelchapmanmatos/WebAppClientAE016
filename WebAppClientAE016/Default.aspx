<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppClientAE016._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Customers</h4>
    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Label" class="control-label">Id</asp:Label>
                <asp:TextBox ID="Id" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Label" class="control-label">Name</asp:Label>
                <asp:TextBox ID="Name" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Label" class="control-label">Adress</asp:Label>
                <asp:TextBox ID="Adress" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Label" class="control-label">Age</asp:Label>
                <asp:TextBox ID="Age" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Label" class="control-label">Phone</asp:Label>
                <asp:TextBox ID="Phone" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Label" class="control-label">NIE</asp:Label>
                <asp:TextBox ID="NIE" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Label" class="control-label">Status</asp:Label>
                <asp:TextBox ID="Status" runat="server" class="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" class="btn btn-primary" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" class="btn btn-warning" />
            <asp:Button ID="btnUpdateStatus" runat="server" Text="Update Status" OnClick="btnUpdateStatus_Click" class="btn btn-danger" />
            <asp:Button ID="btnViewListClient" runat="server" Text="View List Client" OnClick="btnViewListClient_Click" class="btn btn-success" />
        </div>
        <div class="col-md-8">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" CssClass="thead-dark" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
