using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Paciente
    {
        public int Id_Paciente {  get; set; }
        public string nombres {  get; set; }
        public string apellidos {  get; set; }
        public string correo {  get; set; }
        public string dni { get; set; }
        public string telefono {  get; set; }
    }
}
