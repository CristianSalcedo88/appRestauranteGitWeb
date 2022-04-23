using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.datos
{
    public class clEmpleadoD
    {
        public int mtdregistrarEmpleado(clEmpleadoE objDataEmpleadoE)
        {
            string sql = "insert into empleado (nombreEmpleado,tipoEmpleado) " +
                "values('" + objDataEmpleadoE.nombreEmpleado + "'," +
                "'" + objDataEmpleadoE.tipoEmpleado + "')";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);

            return resultado;
        }
    }
}