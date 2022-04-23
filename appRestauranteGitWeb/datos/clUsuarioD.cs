using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.datos
{
    public class clUsuarioD
    {
        public int mtdRegistrarUsuario(clUsuarioE objDatosU)
        {
            string sql = "insert into usuario(nombre,apellido,documento) values('"+objDatosU.nombre+ "'" +
                ",'" + objDatosU.apellido + "','" + objDatosU.documento + "',)";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;
        }
    }
}