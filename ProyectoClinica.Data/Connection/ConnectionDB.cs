using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Data.Connection
{
    public class ConnectionDB
    {
        private static readonly string connectionString =
            "Server=DESKTOP-QDE61J8;Database=ClinicaDB;User ID=sa;Password=123456;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
