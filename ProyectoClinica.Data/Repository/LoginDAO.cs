using ProyectoClinica.Data.Connection;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Data.Repository
{
    public class LoginDAO
    {
        public Login LoginUsuario(string usuario, string clave)
        {
            Login login = null;

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "SELECT * FROM Login WHERE usuario=@usuario AND clave=@clave";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    login = new Login();
                    login.Roles = new Roles();
                    login.Doctores = new Doctores();

                    login.Id_Login = Convert.ToInt32(dr["id_login"]);

                    if (dr["id_rol"] != DBNull.Value)
                        login.Roles.id_Roles = Convert.ToInt32(dr["id_rol"]);

                    if (dr["id_doctor"] != DBNull.Value)
                        login.Doctores.Id_doctor = Convert.ToInt32(dr["id_doctor"]);

                    login.usuario = dr["usuario"].ToString();
                    login.clave = dr["clave"].ToString();
                }
                dr.Close();
            }
            return login; 
        }
    }
}
