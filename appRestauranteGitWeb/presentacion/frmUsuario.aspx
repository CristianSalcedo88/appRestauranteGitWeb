<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="appRestauranteGitWeb.frmUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div _designerregion="0">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="idUsuario" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." GridLines="Vertical" Height="178px" Width="497px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
                <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbGitRetauranteConnectionString1 %>" DeleteCommand="DELETE FROM [usuario] WHERE [idUsuario] = @idUsuario" InsertCommand="INSERT INTO [usuario] ([nombre], [apellido], [documento]) VALUES (@nombre, @apellido, @documento)" ProviderName="<%$ ConnectionStrings:dbGitRetauranteConnectionString1.ProviderName %>" SelectCommand="SELECT [idUsuario], [nombre], [apellido], [documento] FROM [usuario]" UpdateCommand="UPDATE [usuario] SET [nombre] = @nombre, [apellido] = @apellido, [documento] = @documento WHERE [idUsuario] = @idUsuario">
            <DeleteParameters>
                <asp:Parameter Name="idUsuario" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellido" Type="String" />
                <asp:Parameter Name="documento" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellido" Type="String" />
                <asp:Parameter Name="documento" Type="String" />
                <asp:Parameter Name="idUsuario" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    
</asp:Content>
