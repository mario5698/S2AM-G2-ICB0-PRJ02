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
        }

        private void Conectar(string query)
        {
            conexion = new SqlConnection(connectionString);

            if (query != null && query != "")
            {
                adaptador = new SqlDataAdapter(query, conexion);
                
                if (conexion.State == ConnectionState.Closed) conexion.Open();
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
            adaptador.Update(dts.Tables["users"]);
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
    }
}
