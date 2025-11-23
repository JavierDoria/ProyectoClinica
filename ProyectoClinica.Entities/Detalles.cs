using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Detalles
    {
        public int Id_DetalleReceta {  get; set; }
        public Medicina Medicina { get; set; } = new Medicina();
        public Receta Receta { get; set; } = new Receta();
        public string indicaciones { get; set; }
    }
}
