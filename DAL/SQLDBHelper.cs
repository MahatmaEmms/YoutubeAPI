using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //agregamos estos using
using System.Data; //agregamos estos using

namespace DAL
{
    public class SQLDBHelper
    {
        public readonly string connectionString = "Data Source=DESKTOP-FBDGKUS\\SERVERMIO;Initial Catalog=Youtube;Integrated Security=True";

        public void GuardarBusqueda(string informacion) // Cambia el parámetro a 'informacion'
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Busquedas (Informacion) VALUES (@informacion)"; // Cambia 'Query' a 'Informacion'
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@informacion", SqlDbType.NVarChar).Value = informacion; // Cambia 'query' a 'informacion'
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
