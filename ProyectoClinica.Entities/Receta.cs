using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Receta
    {
        public int Id_receta { get; set; }
        public Doctores Doctor { get; set; } = new Doctores();
        public Paciente Paciente { get; set; } = new Paciente();
        public string diagnostico {  get; set; }
        public DateTime fecha { get; set; }
    }
}
