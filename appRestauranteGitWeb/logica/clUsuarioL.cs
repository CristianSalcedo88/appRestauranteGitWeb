using appRestauranteGitWeb.datos;
using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.logica
{
    public class clUsuarioL
    {
        public int mtdRegistrarUsuario(clUsuarioE objDatosU)
        {
            clUsuarioD objclUsuarioD = new clUsuarioD();
            int result = objclUsuarioD.mtdRegistrarUsuario(objDatosU);
            return result;
        }
    }
}