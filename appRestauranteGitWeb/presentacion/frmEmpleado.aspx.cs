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

       
        

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            clEmpleadoE ObjEmpleadoE = new clEmpleadoE();
            clEmpleadoL ObjEmpleadoL = new clEmpleadoL();

            ObjEmpleadoE.nombreEmpleado = txtnombre.Text +" "+ txtapellido.Text;
            ObjEmpleadoE.tipoEmpleado = txttipoEmpleado.Text;

           int filas= ObjEmpleadoL.mtdRegistrarEmpleado(ObjEmpleadoE);
            string alerta = "datos insertados correctamente";

            if(filas>0)
            {
                Label1.Text = "Datos insertados correctamente";
            }
            else
            {
                Label1.Text = "Error al insertar datos";
            }
        }
    }
}