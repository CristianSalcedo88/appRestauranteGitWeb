<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="appRestauranteGitWeb.frmUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Documento"></asp:Label>
    <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
    <br />
    <asp:Button ID="btnListar" runat="server" Text="Listar" />
    <br />
    <asp:GridView ID="dgvMostrarUsuarios" runat="server"></asp:GridView>
    <br />
    <asp:Label ID="lblRespuesta" runat="server" Text=""></asp:Label>

</asp:Content>
