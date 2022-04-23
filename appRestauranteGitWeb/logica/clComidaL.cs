using appRestauranteGitWeb.datos;
using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.logica
{
    public class clComidaL
    {
        public List<clComidaE> mtdListarComidaL()
        {
            clComidaD objComida = new clComidaD();
            List<clComidaE> listaComida = new List<clComidaE>();
            listaComida = objComida.mtdListarComidaD();
            return listaComida;
        }
    }
}