using ProyectoClinica.Data.Connection;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Data.Repository
{
    public class DoctorDAO
    {
        public List<Doctores> ObtenerDoctores()
        {
            List<Doctores> lista = new List<Doctores>();
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"SELECT d.Id_doctor, d.nombres, d.apellidos, d.dni, d.telefono, 
                                      d.correo, d.id_especialidad, e.carrera 
                               FROM Doctores d
                               INNER JOIN Especialidades e ON d.id_especialidad = e.Id_Especialidad";
                SqlCommand cmd = new SqlCommand(sql, cn);
                
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Doctores listas = new Doctores
                    {
                        Id_doctor = Convert.ToInt32(dr["Id_doctor"]),
                        nombre = dr["nombres"].ToString(),
                        apellido = dr["apellidos"].ToString(),
                        dni = dr["dni"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        correo = dr["correo"].ToString(),
                        Especialidad = new Especialidad
                        {
                            Id_Especialidad = Convert.ToInt32(dr["id_especialidad"]),
                            carrera = dr["carrera"].ToString()
                        }
                    };
                    lista.Add(listas);
                }
            }
            return lista;
        }
        public Doctores buscarPorDni(string dni)
        {
            Doctores doctor = null;
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"SELECT d.Id_doctor, d.nombres, d.apellidos, d.dni, d.telefono, d.correo,
                               d.id_especialidad,
                               e.carrera
                        FROM Doctores d
                        INNER JOIN Especialidades e ON d.id_especialidad = e.Id_Especialidad
                        WHERE d.dni = @dni";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@dni", dni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    doctor = new Doctores()
                    {
                        Id_doctor = Convert.ToInt32(dr["Id_doctor"]),
                        nombre = dr["nombres"].ToString(),
                        apellido = dr["apellidos"].ToString(),
                        dni = dr["dni"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        correo = dr["correo"].ToString(),

                        Especialidad = new Especialidad()
                        {
                            Id_Especialidad = Convert.ToInt32(dr["id_especialidad"]),
                            carrera = dr["carrera"].ToString()
                        }
                    };
                }
            }
            return doctor;
        }
        public int agregarDoctor(Doctores doctor)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"INSERT INTO Doctores(nombres, apellidos, dni, telefono, correo, id_especialidad)
                               VALUES(@nombres, @apellidos, @dni, @telefono, @correo, @id_especialidad)";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nombres", doctor.nombre);
                cmd.Parameters.AddWithValue("@apellidos", doctor.apellido);
                cmd.Parameters.AddWithValue("@dni", doctor.dni);
                cmd.Parameters.AddWithValue("@telefono", doctor.telefono);
                cmd.Parameters.AddWithValue("@correo", doctor.correo);
                cmd.Parameters.AddWithValue("@id_especialidad", doctor.Especialidad.Id_Especialidad);

                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public int Actualizar(Doctores doctor)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"UPDATE Doctores SET 
                               nombres=@nombres, apellidos=@apellidos, dni=@dni, telefono=@telefono,
                               correo=@correo, id_especialidad=@id_especialidad
                               WHERE id_doctor=@id_doctor";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nombres", doctor.nombre);
                cmd.Parameters.AddWithValue("@apellidos", doctor.apellido);
                cmd.Parameters.AddWithValue("@dni", doctor.dni);
                cmd.Parameters.AddWithValue("@telefono", doctor.telefono);
                cmd.Parameters.AddWithValue("@correo", doctor.correo);
                cmd.Parameters.AddWithValue("@id_especialidad", doctor.Especialidad.Id_Especialidad);
                cmd.Parameters.AddWithValue("@id_doctor", doctor.Id_doctor);

                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public int Eliminar(int id)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"DELETE FROM Doctores WHERE id_doctor = @id_doctor";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id_doctor", id);

                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
