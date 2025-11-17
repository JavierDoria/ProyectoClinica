using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Doctores
    {
        private int Id_doctor { get; set; }
        private string nombre {  get; set; }
        private string apellido {  get; set; }
        private string dni {  get; set; }
        private string telefono { get; set; }
        private Especialidad Id_Especialidad { get; set; }
        private string correo { get; set; }
    }
}
