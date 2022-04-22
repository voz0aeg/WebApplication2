using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

namespace dbcons.db
{
    public class dbCon
    {
        public static SqlConnection Conexion = new SqlConnection("Data Source = SQL5097.site4now.net; Initial Catalog = db_a85d13_voz0aeg; User Id = db_a85d13_voz0aeg_admin; Password=Idiotas82");

        public bool Guardar(string q)
        {
            try
            {
                Conexion.Open();
                SqlCommand Comando;
                Comando = new SqlCommand(q, Conexion);

                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                return false;
            }
        }

        public DataTable Consulta2(string q)
        {
            try
            {
                DataTable t = new DataTable();
                var Adaptador = new SqlDataAdapter(q, Conexion);
                DataSet ds = new DataSet();
                Adaptador.Fill(ds);
                t = ds.Tables[0];
                return t;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataRow Consulta1(string q)
        {
            try
            {
                var Adaptador = new SqlDataAdapter(q, Conexion);
                var ds = new DataSet();
                Adaptador.Fill(ds);
                DataRow fila;

                if (ds.Tables[0].Rows.Count > 0)
                    fila = ds.Tables[0].Rows[0];
                else
                    fila = null;
                return fila;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }
}
