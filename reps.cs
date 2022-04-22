using dbcons.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class reps
    {
        dbCon f = new dbCon();
        public Cliente CargaDatos(string value)
        {
            var r = f.Consulta1("select *, convert(date,FNac,101)FNac2 from t_clientes where id='" + value + "'");

            DateTime d = Convert.ToDateTime(r["FNac2"].ToString());  


            Cliente c = new Cliente();
            c.nombre = r["nombre"].ToString();
            c.ap = r["ap"].ToString();
            c.am = r["am"].ToString();
            c.FNac = Convert.ToDateTime(d);
            c.cp = r["cp"].ToString();
            c.Col = r["Col"].ToString();
            c.Mun = r["Mun"].ToString();
            c.Edo = r["Edo"].ToString();
            c.Tel = r["Tel"].ToString();
            c.Cel = r["Cel"].ToString();
            c.Email = r["Email"].ToString();
            return c;
        }
        public void SaveCliente(Cliente c)
        {
            string q;
            q = "INSERT INTO dbo.t_Clientes VALUES" +
"('" + c.nombre + "'" +
", '" + c.ap + "'" +
", '" + c.am + "'" +
", convert(date,'" + c.FNac.ToString("dd/MM/yyyy") + "',103)" +
", '" + c.cp + "'" +
", '" + c.Col + "'" +
", '" + c.Mun + "'" +
", '" + c.Edo + "'" +
", '" + c.Tel + "'" +
", '" + c.Cel + "'" +
", '" + c.Email + "')";

            f.Guardar(q);
        }

        internal void UpdateCliente(Cliente c)
        {
            var q= "update t_Clientes set nombre='" + c.nombre + "', ap='" + c.ap + "', am='" + c.am + "', " +
"FNac = convert(date,'" + c.FNac.ToString("dd/MM/yyyy") + "',103),cp = '" + c.cp + "', Col = '" + c.Col + "', Mun = '" + c.Mun + "', " +
"Edo = '" + c.Edo + "', Tel = '" + c.Tel + "', Cel = '" + c.Cel + "', Email = '" + c.Email + "' " +
"where id = '" + c.id + "'";
            f.Guardar(q);
        }
    }
}