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
    public class EspecialidadDAO
    {
        public List<Especialidad> ObtenerEspecialidad()
        {
            List<Especialidad> lista = new List<Especialidad>();
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "SELECT Id_Especialidad, carrera FROM Especialidades";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Especialidad
                    {
                        Id_Especialidad = Convert.ToInt32(dr["Id_Especialidad"]),
                        carrera = dr["carrera"].ToString()
                    });
                }
            }
            return lista;
        }
        public int RegistrarEspecialidad(Especialidad esp)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "INSERT INTO Especialidades (carrera) VALUES (@carrera)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@carrera", esp.carrera);

                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public int ActualizarEspecialidad(Especialidad esp)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "UPDATE Especialidades SET carrera=@carrera WHERE Id_Especialidad=@id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@carrera", esp.carrera);
                cmd.Parameters.AddWithValue("@id", esp.Id_Especialidad);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public int EliminarEspecialidad(int id)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "DELETE FROM Especialidades WHERE id_especialidad=@id_especialidad";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id_especialidad", id);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public bool EspecialidadEnUso(int id)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM Doctores WHERE id_especialidad = @id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public Especialidad Buscar(int id)
        {
            Especialidad esp = null;

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = "SELECT * FROM Especialidades WHERE id_especialidad = @id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    esp = new Especialidad()
                    {
                        Id_Especialidad = Convert.ToInt32(dr["id_especialidad"]),
                        carrera = dr["carrera"].ToString()
                    };
                }
            }

            return esp;
        }
    }
}
