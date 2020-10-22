using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassConnection
{
    public class Connection
    {
        private SqlConnection conn;
        private string cnx = "Data Source=ATHERIS\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True";
        private string query;
        DataSet dts;

        public DataTable Traer_Datos()
        {
            //Configurar_Conexion();
            conn = new SqlConnection(cnx);
            SqlDataAdapter adapter;
            dts = new DataSet();
            query = "select * from agencies";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts, "Users");
            return dts.Tables["Users"];
        }
    }
}
