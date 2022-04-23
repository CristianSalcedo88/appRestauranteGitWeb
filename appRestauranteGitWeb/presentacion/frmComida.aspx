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

            <asp:GridView ID="dgvComida" runat="server" AutoGenerateColumns="False" DataKeyNames="idComida" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="idComida" HeaderText="idComida" InsertVisible="False" ReadOnly="True" SortExpression="idComida" />
                    <asp:BoundField DataField="nombreComida" HeaderText="nombreComida" SortExpression="nombreComida" />
                    <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbGitRetauranteConnectionString2 %>" SelectCommand="SELECT * FROM [comida]"></asp:SqlDataSource>

            <br />
            <br />
            <br />
            <br />

          

            <asp:Button ID="btnListar" runat="server" Text="Listar" />
           

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
