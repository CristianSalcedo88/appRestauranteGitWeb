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
    public partial class frmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            clUsuarioE objDatosU = new clUsuarioE();
            objDatosU.nombre = txtNombre.Text;
            objDatosU.apellido = txtApellido.Text;
            objDatosU.documento = txtDocumento.Text;

            clUsuarioL objUsuarioL = new clUsuarioL();
            int filas = objUsuarioL.mtdRegistrarUsuario(objDatosU);
            if (filas > 0)
            {
                lblRespuesta.Text = "Datos insertados Correctamente";
            }
            else
            {
                lblRespuesta.Text = "Error al insertar Datos";
            }
        }
    }
}