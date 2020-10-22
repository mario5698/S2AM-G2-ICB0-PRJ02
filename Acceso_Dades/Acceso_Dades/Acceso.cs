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
        #region varibles globales 
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
        private SqlConnection conn;
        private string query;
        DataSet dts;
        #endregion
        SqlDataAdapter adapter;

        public Acceso()
        {
            conn = new SqlConnection(connectionString);
        }

        #region Events 
        public DataTable Traer_Datos(string tabla)
        {
            conn.Close();
            dts = new DataSet();
            query = "select * from users";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts, tabla);
            return dts.Tables[tabla];   
        }

        public bool Verficar_User(String user, String password)
        {
            conn.Close();
            dts = new DataSet();
            query = "select * from users where login = '" + user + "' and password = '" + password + "'";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts, "Users");

            return dts.Tables["Users"].Rows.Count > 0;
        }

        #endregion

    }
}
