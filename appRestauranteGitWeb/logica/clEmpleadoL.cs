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
        public int mtdRegistrarEmpleado(clEmpleadoE objdatos)
        {
            clEmpleadoD objEmpleadoD = new clEmpleadoD();
            int filasAfectadas = objEmpleadoD.mtdregistrarEmpleado(objdatos);
            return filasAfectadas;
        }
    }
}