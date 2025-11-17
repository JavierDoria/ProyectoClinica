using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Receta
    {
        private int Id_receta { get; set; }
        private Doctores Id_Doctor { get; set; }
        private Paciente Id_Paciente { get; set; }
        private string diagnostico {  get; set; }
        private DateTime fecha { get; set; }
    }
}
