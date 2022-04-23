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
        public List<clEmpleadoE> mtdListarPas()
        {
            clEmpleadoD objPacienteD = new clEmpleadoD();
            List<clEmpleadoE> listaPacientes = new List<clEmpleadoE>();
            listaPacientes = objPacienteD.mtdListar();
            return listaPacientes;



        }
    }
}