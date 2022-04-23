using appRestauranteGitWeb.entidades;
using appRestauranteGitWeb.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appRestauranteGitWeb
{
    public partial class frmEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            clEmpleadoE objEmpleadosE = new clEmpleadoE();
            objEmpleadosE.nombreEmpleado = txtNombreEmple.Text;
            objEmpleadosE.nombreEmpleado = txtTipoEmpleado.Text;


            clEmpleadoL objProductosL = new clEmpleadoL();
            int filas = objProductosL.mtdRegistarUsuario(objEmpleadosE);
            if (filas > 0)
            {
                lblMensaje.Text = "EMPLEADO REGISTRADO";
            }
            else
            {
                lblMensaje.Text = "ERROR AL REGISTRAR EL PRODUCTO ";
            }

        }
    }
}