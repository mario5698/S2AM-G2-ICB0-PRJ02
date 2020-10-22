using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Dades
{
    public class Acceso
    {
        #region varibles globales 
        private SqlConnection conn;
        private string cnx = "Data Source=LAPTOP-99OC5OLH\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True";
        private string query;
        DataSet dts;
        #endregion

        #region Events 
        public DataTable Traer_Datos()
        {
            //Configurar_Conexion();
            conn = new SqlConnection(cnx);
            SqlDataAdapter adapter;
            dts = new DataSet();
            query = "select * from users";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts, "Users");
            return dts.Tables["Users"];   
        }
        public bool Verficar_User(String user, String password)
        {
            //Configurar_Conexion();
            bool correct_user;
            conn = new SqlConnection(cnx);
            SqlDataAdapter adapter;
            dts = new DataSet();
            query = "select * from users where login = '" + user + "' and password = '" + password + "'";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts, "Users");

            if (dts.Tables["Users"].Rows.Count > 0)
            {
                correct_user = true;

            } else
            {
                correct_user = false;
            };

            return correct_user;
        }

        }
        #endregion

    }

