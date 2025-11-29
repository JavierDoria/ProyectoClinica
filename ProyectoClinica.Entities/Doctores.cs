using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Doctores
    {
        public int Id_doctor { get; set; }
        public string nombre {  get; set; }
        public string apellido {  get; set; }
        public string dni {  get; set; }
        public string telefono { get; set; }
        [Browsable(false)]
        public Especialidad Especialidad { get; set; } = new Especialidad();
        public string correo { get; set; }

        public string NombreEspecialidad
        {
            get { return Especialidad.carrera; }
        }
    }
}
