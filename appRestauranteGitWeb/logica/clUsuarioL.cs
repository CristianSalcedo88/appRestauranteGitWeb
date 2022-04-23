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
        public clUsuarioE mtdSelectUsuario(clUsuarioE objdatosUser)
        {
            clUsuarioD objUsuariosD = new clUsuarioD();
            clUsuarioE objdatosUsuario = new clUsuarioE();
            objdatosUsuario = objUsuariosD.mtdSelect(objdatosUser);
            return objdatosUsuario;
        }
    }
}