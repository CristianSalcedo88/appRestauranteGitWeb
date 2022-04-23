<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmEmpleado.aspx.cs" Inherits="appRestauranteGitWeb.frmEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1><center>Registro de Empleados</center>   </h1>

    <div class="col offset-6 col-md-2 mt-4">
                
<%--            <div class ="card car-body login-card-body"> --%>

            <%--   
        <div class ="container">
            <div class="d-flex justify-content-center">--%>

                <div class="mb-6 mt-6">
                    <label for="nombre Empleado" class="form-label">nombre Empleado:</label>

                    <asp:TextBox ID="txtNombreEmple" runat="server" CssClass="form-control" placeholder="nombre del Empleado " TextMode="MultiLine"></asp:TextBox>


                     <label for="tipoEmpleado" class="form-label">Tipo de Empleado :</label>

                    <asp:TextBox ID="txtTipoEmpleado" runat="server" CssClass="form-control" placeholder="Tipo de Empleado " TextMode="MultiLine"></asp:TextBox>

                   <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                   

                    
                    <asp:Button ID="btnRegistrarEmpleado" runat="server" Text="Registrar Empleado" OnClick="btnRegistrarEmpleado_Click"  />
</div>
        </div>
        
        </div>
    </div>




</asp:Content>
