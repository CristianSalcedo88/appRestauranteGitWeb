using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.datos
{
    public class clEmpleadoD
    {
        public int mtdRegistrar(clEmpleadoE objDatosEmpleados)
        {
            string sql = "insert into empleado(nombreEmpleado,tipoEmpleado)" +
                "values ('" + objDatosEmpleados.nombreEmpleado + "' ,'" + objDatosEmpleados.tipoEmpleado + "')";
            clConexion objConexion = new clConexion();
            int x = 0;
            int resulatdo = objConexion.mtdConectado(sql);
            //cambio
            return resulatdo;
        }


    }
}