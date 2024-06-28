using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.personas
{
    public class Validacionp
    {
        public bool ValidarCedula(string cedula)
        {
            bool c = true;
            if (cedula.Length != 10)
            {
                c = false;
            }
            return c;
        }

        public bool ValidarTelefono(string telefono)
        {
            bool campo = true;
            if (telefono.Length != 10)
            {
                campo = false;
            }
            return campo;
        }

        public bool ValidarCelular(string celu)
        {
            bool campo = true;
            if (celu.Length != 10)
            {
                campo = false;
            }
            return campo;
        }

        public bool validarEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

    }

}
