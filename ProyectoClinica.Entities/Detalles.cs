using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Detalles
    {
        private int Id_DetalleReceta {  get; set; }
        private Medicina  Id_Medicina {  get; set; }
        private Receta Id_Receta {  get; set; }
        private string indicaciones { get; set; }
    }
}
