<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmEmpleado.aspx.cs" Inherits="appRestauranteGitWeb.frmEmpleado" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="nombre" runat="server" Text="nombre"></asp:Label><br />
    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox><br />
     <asp:Label ID="apellido" runat="server" Text="apellido"></asp:Label><br />
    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox><br />
     <asp:Label ID="tipo" runat="server" Text="tipo"></asp:Label><br />
<asp:TextBox ID="txttipoEmpleado" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnregistrar" runat="server" Text="registrar" OnClick="btnregistrar_Click" />
</asp:Content>
