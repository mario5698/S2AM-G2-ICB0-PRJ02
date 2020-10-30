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
        }

        private void Conectar(string query)
        {
            conexion = new SqlConnection(connectionString);

            if (query != null && query != "")
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

        public DataTable PortarTaula(string tabla)
        {
            dts = new DataSet();
            query = "select * from " + tabla;
            Conectar(query);
            adaptador.Fill(dts, tabla);
            conexion.Close();
            return dts.Tables[tabla];   
        }

        public void Actualitzar()
        {
            conexion.Open();
            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(query, conexion);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);
            adaptador.Update(dts.Tables[0]);
            conexion.Close();
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            dts = new DataSet();
            Conectar(consulta);
            adaptador.Fill(dts);
            conexion.Close();
            return dts;
        }
        public DataSet PortarPerConsulta(string consulta, string tabla)
        {
            dts = new DataSet();
            Conectar(consulta);
            adaptador.Fill(dts, tabla);
            conexion.Close();
            return dts;
        }

        public int Executa(string consult)
        {
            Conectar(consult);
            SqlCommand cmd = new SqlCommand(consult, conexion);
            int registresAfectats = cmd.ExecuteNonQuery();
            return registresAfectats;
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
