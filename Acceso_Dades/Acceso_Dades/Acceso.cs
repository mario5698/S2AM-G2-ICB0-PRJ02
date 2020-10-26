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
        string query;
        DataSet dts;


        public Acceso()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
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
            conexion.Close();
            return dts.Tables[tabla];   
        }

        public void Actualizar_BBDD()
        {
            conexion.Open();
            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(query, conexion);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);
            adaptador.Update(dts.Tables["users"]);
            conexion.Close();
        }

        public bool Verficar_User(String consulta)
        {
            dts = new DataSet();

            Conectar(consulta);
            adaptador.Fill(dts, "Users");
            return dts.Tables["Users"].Rows.Count > 0;
        }
        public void Ejecutar(string query)
        {
            Conectar(query);
        }

    }
}
