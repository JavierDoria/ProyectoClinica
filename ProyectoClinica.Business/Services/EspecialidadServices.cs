using ProyectoClinica.Data.Repository;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Business.Services
{
    public class EspecialidadServices
    {
        private readonly EspecialidadDAO dao = new EspecialidadDAO();


        public List<Especialidad> Listar()
        {
            return dao.ObtenerEspecialidad();
        }
        public bool Registrar(Especialidad esp)
        {
            return dao.RegistrarEspecialidad(esp) > 0;
        }
        public bool Actualizar(Especialidad esp)
        {
            return dao.ActualizarEspecialidad(esp) > 0;
        }
        public bool Eliminar(int id)
        {
            return dao.EliminarEspecialidad(id) > 0;
        }
        public bool EspecialidadEnUso(int id)
        {
            return dao.EspecialidadEnUso(id);
        }
        public Especialidad Buscar(int id)
        {
            return dao.Buscar(id);
        }
    }
}
