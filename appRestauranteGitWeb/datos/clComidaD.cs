using appRestauranteGitWeb.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appRestauranteGitWeb.datos
{
    public class clComidaD
    {
        public List<clComidaE> mtdListarComidaD()
        {
            string sql = "select * from comida";
            clConexion objConexion = new clConexion();
            DataTable tblComida = new DataTable();
            tblComida = objConexion.mtdDesconectado(sql);

            List<clComidaE> ListaComida = new List<clComidaE>();

            int canReg = tblComida.Rows.Count;

            for (int i = 0; i < canReg; i++)
            {
                clComidaE objDatosComida = new clComidaE();
                objDatosComida.idComida = int.Parse(tblComida.Rows[i]["idComida"].ToString());
                objDatosComida.nombreComida = tblComida.Rows[i]["nombreComida"].ToString();
                objDatosComida.precio = float.Parse(tblComida.Rows[i]["precio"].ToString());
                ListaComida.Add(objDatosComida);
            }
            return ListaComida;
        }
    }
}