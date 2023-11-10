<% @Page Language="C#" MasterPageFile="Main.master" AutoEventWireup="true"
Src="NewRegister.aspx.cs" Inherits="NewRegister" Title="Registrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
  <div class="new-contact">
    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    
    <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
    <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
    
    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    
    <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
    
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnSubmit_Click" />
</div>
</asp:Content>
