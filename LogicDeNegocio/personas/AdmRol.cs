using LogicDeNegocio.provincia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.personas
{
    public class AdmRol
    {
        Rol r = new Rol();
        public List<Rol> ConsultarRol(string dato)
        {
            List<Rol> rol = null;
            rol = r.BuscarRol(dato);
            if (rol.Count == 0)
            {
                throw new ExceptionSistema("No se encontraron registros");
            }
            return rol;
        }
        public bool insertRol(Rol rol)
        {
            Rol r = rol;
            r.InsertarRol(r);
            return true;
        }
    }
}
