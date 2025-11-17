using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.Entities
{
    public class Login
    {
        private int Id_Login {  get; set; }
        private Roles id_Roles { get; set; }
        private Doctores Id_Doctores { get; set; }
        private string usuario { get; set; }
        private string clabe { get; set; }
    }
}
