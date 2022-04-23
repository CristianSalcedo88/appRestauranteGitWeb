using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.datos
{
    public class clEmpleadoD
    {
        public List<clEmpleadoE> mtdListar()
        {
            string sql = "select * from paciente ";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleado = new DataTable();
            tblEmpleado = objConexion.mtdDesconectado(sql);

            List<clEmpleadoE> listarEmpleados = new List<clEmpleadoE>();

            int catnReg = tblEmpleado.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clEmpleadoE objDatosPaciente = new clEmpleadoE();
                objDatosPaciente.idEmpleado = int.Parse(tblEmpleado.Rows[i]["idEmpleado"].ToString());
                objDatosPaciente.nombreEmpleado = tblEmpleado.Rows[i]["nombreEmpleado"].ToString();
                objDatosPaciente.tipoEmpleado = tblEmpleado.Rows[i]["tipoEmpleado"].ToString();
                objDatosPaciente.apellido = tblEmpleado.Rows[i]["apellido"].ToString();
               
               

                listarEmpleados.Add(objDatosPaciente);
            }

            return listarEmpleados;

        }

    }
}
