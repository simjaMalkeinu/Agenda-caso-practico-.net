<% @Page Language="C#" MasterPageFile="Main.master" AutoEventWireup="true"
Src="Default.aspx.cs" Inherits="Default" Title="Contactos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="misContactos">
        <asp:DataGrid ID="misContactos" runat="server" AutoGenerateColumns="true"></asp:DataGrid>
        <br>
        <asp:Label ID="alert" runat="server" Text="No hay contactos registrados"></asp:Label>
    </div>
</asp:Content>
