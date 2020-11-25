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
    public class Acceso : Conexion
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


        public bool LoginCorrecto(string user, string pass)
        {
            Conectar();
            SqlCommand command = conexion.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM [Users] " +
            "WHERE [Login] = @User " +
            "AND [Password] = @Password";
            command.Parameters.Add(new SqlParameter("@User", user));
            command.Parameters.Add(new SqlParameter("@Password", pass));
            int rows = (int)command.ExecuteScalar();
            conexion.Close();
            return rows == 1;
        }
    }
}
