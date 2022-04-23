using appRestauranteGitWeb.datos;
using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.logica
{
    public class clEmpleadoL
    {

        public int mtdRegistarUsuario(clEmpleadoE objDatosProduct)
        {
            clEmpleadoD objEmpleadosD = new clEmpleadoD();
            int resultado = objEmpleadosD.mtdRegistrar(objDatosProduct);
            return resultado;
        }

    }
}