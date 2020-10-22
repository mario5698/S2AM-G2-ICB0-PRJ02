using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Acceso_Dades
{
    public class Acceso
    {
        private string connectionString;
        private SqlConnection conexion;
        SqlDataAdapter adaptador;
        String query;
        DataSet dts;


        public Acceso()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
            conexion = new SqlConnection(connectionString);
        }

        private void Conectar(string query)
        {
            if (query != null && query != "")
            {
                adaptador = new SqlDataAdapter(query, conexion);
                
                if (conexion.State == ConnectionState.Closed) conexion.Open();
            }
        }

        public DataTable Traer_Tabla(string tabla)
        {
            dts = new DataSet();
            query = "select * from " + tabla;
            Conectar(query);
            adaptador.Fill(dts, tabla);
            return dts.Tables[tabla];   
        }

        public bool Verficar_User(String user, String password)
        {
            dts = new DataSet();
            query = "select * from users where login = '" + user + "' and password = '" + password + "'";
            Conectar(query);
            adaptador.Fill(dts, "Users");
            return dts.Tables["Users"].Rows.Count > 0;
        }

        public void Actualizar(DataSet ds)
        {
            Conectar(query);
            adaptador.Update(ds);
        }

        public void Ejecutar(string query)
        {
            Conectar(query);
        }
    }
}
