using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Medicina
    {
        public int Id_Medicina {  get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
    }
}
