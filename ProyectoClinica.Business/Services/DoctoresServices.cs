using ProyectoClinica.Data.Repository;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Business.Services
{
    public class DoctoresServices
    {
        private readonly DoctorDAO doctoresDAO = new DoctorDAO();
        public List<Doctores> ObtenerDoctores()
        {
            return doctoresDAO.ObtenerDoctores();
        }
        public Doctores BuscarPorDni(string dni)
        {
            return doctoresDAO.buscarPorDni(dni);
        }
        public bool Agregar(Doctores doctor)
        {
            string error = ValidarDoctor(doctor, esActualizacion: false);
            if (error != null)
                throw new Exception(error);
            try
            {
                int filas = doctoresDAO.agregarDoctor(doctor);
                return filas > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("El correo ya está registrado. Intente con otro.");
                }
                throw;
            }
        }
        private string ValidarDoctor(Doctores doctor, bool esActualizacion = false)
        {
            if (doctor == null)
                return "El objeto doctor es nulo.";

            if (string.IsNullOrWhiteSpace(doctor.nombre))
                return "El nombre es obligatorio.";

            if (string.IsNullOrWhiteSpace(doctor.apellido))
                return "El apellido es obligatorio.";

            if (string.IsNullOrWhiteSpace(doctor.dni))
                return "El DNI es obligatorio.";

            if (doctor.dni.Length != 8)
                return "El DNI debe tener 8 dígitos.";
            if (doctor.dni.Length != 8)
                return "El dni debe tener 9 dígitos.";

            if (string.IsNullOrWhiteSpace(doctor.telefono))
                return "El teléfono es obligatorio.";
            if (doctor.telefono.Length != 9)
                return "El teléfono debe tener 9 dígitos.";

            if (doctor.Especialidad == null || doctor.Especialidad.Id_Especialidad <= 0)
                return "Debe seleccionar una especialidad válida.";

            if (string.IsNullOrWhiteSpace(doctor.correo))
                return "El correo es obligatorio.";

            if (!doctor.correo.Contains("@"))
                return "El correo no es válido.";

            return null;
        }
        public bool Actualizar(Doctores doctor)
        {
            string error = ValidarDoctor(doctor, esActualizacion: true);

            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }
            int filas = doctoresDAO.Actualizar(doctor);
            return filas > 0;
        }
        public bool Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            int filas = doctoresDAO.Eliminar(id);
            return filas > 0;
        }
    }
}
