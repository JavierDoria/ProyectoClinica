using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Paciente
    {
        private int Id_Paciente {  get; set; }
        private string nombres {  get; set; }
        private string apellidos {  get; set; }
        private string correo {  get; set; }
        private string dni { get; set; }
        private string telefono {  get; set; }
    }
}
