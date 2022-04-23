using appRestauranteGitWeb.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appRestauranteGitWeb
{
    public partial class frmComida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            clComidaL objcomidaL = new clComidaL();
            dgvComida.DataSource = objcomidaL.mtdListarComidaL();
            dgvComida.DataBind();
        }
    }
}