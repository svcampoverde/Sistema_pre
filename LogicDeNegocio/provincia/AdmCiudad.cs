using LogicDeNegocio.personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.provincia
{
    public class AdmCiudad
    {
        public bool insertCiudad(Ciudad ciud)
        {
            Ciudad c = ciud;
            c.InsertarCiudad(c);
            return true;
        }
    }
}
