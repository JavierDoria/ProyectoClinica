using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Data.Connection
{
    public class Connection
    {
        private static readonly string connectionString =
            "Server=localhost\\SQLEXPRESS01;Database=Clinica;Trusted_Connection=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
