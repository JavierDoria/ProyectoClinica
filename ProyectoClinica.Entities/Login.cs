using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Login
    {
        public int Id_Login {  get; set; }
        public Roles Roles { get; set; } = new Roles();
        public Doctores Doctores { get; set; } = new Doctores();
        public string usuario { get; set; }
        public string clave { get; set; }
    }
}
