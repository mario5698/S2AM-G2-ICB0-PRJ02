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
        private SqlDataAdapter adaptador;
        string query;
        DataSet dts;

        public Acceso()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
            conexion = new SqlConnection(connectionString);
        }

        private void Conectar(string query)
        {
            try
            {
                if (query != null && query != "")
                {
                    adaptador = new SqlDataAdapter(query, conexion);
                    if (conexion.State == ConnectionState.Closed) conexion.Open();
                }
            }
            catch (SqlException)
            {

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
            try
            {
                Conectar(consulta);
                adaptador.Fill(dts, "Users");
                return dts.Tables["Users"].Rows.Count > 0;
            }
            catch(SqlException)
            {

            }
            return dts.Tables["Users"].Rows.Count > 0;
        }

        public void Ejecutar(string query)
        {
            Conectar(query);
        }

        public int NoSQLInjection(string user, string pass)
        {
            conexion.Open();
            SqlCommand command = conexion.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM [Users] " +
            "WHERE [Login] = @User " +
            "AND [Password] = @Password";
            command.Parameters.Add(new SqlParameter("@User", user));
            command.Parameters.Add(new SqlParameter("@Password", pass));
            int x = (int) command.ExecuteScalar();
            conexion.Close();
            return x;
        }

        public void Store()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Ten Most Expensive Products", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Login", "1"));
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
