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
            connectionString = ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
            conexion = new SqlConnection(connectionString);
        }

        private void Conectar(string consulta)
        {
            if (consulta != null && consulta != "")
            {
                adaptador = new SqlDataAdapter(consulta, conexion);
            }

            if (conexion.State == ConnectionState.Closed) conexion.Open();
        }

        public DataTable Traer_Tabla(string tabla)
        {
            query = "select * from " + tabla;
            Conectar(query);
            dts = new DataSet();
            adaptador.Fill(dts, tabla);
            return dts.Tables[tabla];   
        }

        public DataSet Traer_Por_Consulta(string consulta)
        {
            Conectar(consulta);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            return ds;
        }

        public DataSet Traer_Por_Consulta(string consulta, string nombreDataTable)
        {
            Conectar(consulta);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, nombreDataTable);
            return ds;
        }

        public bool Verficar_User(string consulta)
        {
            Conectar(consulta);
            dts = new DataSet();
            adaptador.Fill(dts, "Users");
            return dts.Tables["Users"].Rows.Count > 0;
        }

        public void Actualizar(DataSet ds)
        {
            Conectar(query);
            adaptador.Update(ds);
        }

        public int Ejecutar(string consulta)
        {
            Conectar(consulta);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int registrosAfectados = comando.ExecuteNonQuery();
            comando.Dispose();
            return registrosAfectados;
            //retornar int para mostrar en notify icon
        }
    }
}
