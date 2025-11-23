using ProyectoClinica.Data.Repository;
using ProyectoClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoClinica.Business.Services
{
    public  class LoginServices
    {
        private readonly LoginDAO loginDAO = new LoginDAO();

        public Login IniciarSesion(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception("Debe ingresar al usuario");
            }
            if (string.IsNullOrWhiteSpace(clave))
            {
                throw new Exception("Debe ingresar una clave");
            }

            Login login = loginDAO.LoginUsuario(usuario, clave);
            if (login == null)
            {
                throw new Exception("Usuario o clave incorrecto");
            }
            return login;
        }
    }
}
