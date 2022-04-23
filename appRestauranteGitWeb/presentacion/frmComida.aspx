<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmComida.aspx.cs" Inherits="appRestauranteGitWeb.frmComida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Text="PEDIDOS RESTAURANTE"></asp:Label>

            <br />
            <br />
            <br />
            <br />

          

            <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click" />
           

            <div class="mb-3 mt-3">
                <label for="nombreComida" class="form-label">Nombre de la comida:</label>
                <input type="text" class="form-control" id="nombreComida" placeholder="Ingrese comida" name="txtComida">
            </div>
            <div class="mb-3">
                <label for="precio" class="form-label">Precio:</label>
                <input type="number" class="form-control" id="precio" placeholder="Ingrese precio" name="txtPrecio">
            </div>
            
          

             <asp:Button ID="btnInsertar"  runat="server" class="btn btn-primary" Text="Insertar" />

        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
