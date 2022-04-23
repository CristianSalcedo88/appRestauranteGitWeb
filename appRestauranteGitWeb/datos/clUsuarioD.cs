using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.datos
{
    public class clUsuarioD
    {
        public clUsuarioE mtdSelect(clUsuarioE objDatos)
        {
            string consulta = "select * from usuario where documento'"+ objDatos.documento + "' and nombre'"+objDatos.nombre+"'";
            clConexion objConexion = new clConexion();
            DataTable tbldatos = new DataTable();
            tbldatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objdatosUsuario = new clUsuarioE();

            if(tbldatos.Rows.Count==1)
            {
                objdatosUsuario.idUsuario = int.Parse(tbldatos.Rows[0]["idUsuario"].ToString());
                objdatosUsuario.nombre = tbldatos.Rows[0]["nombre"].ToString();
                objdatosUsuario.apellido = tbldatos.Rows[0]["apellido"].ToString();
                objdatosUsuario.documento = tbldatos.Rows[0]["documento"].ToString();
            }
            else
            {
                objdatosUsuario = null;
            }
            return objdatosUsuario;

        }
    }
}