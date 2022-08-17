using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_brigde
{
    public class Developer : Empleados
    {
        public Developer(ITipoContacto tipoContacto) : base(tipoContacto)
        {
            Nombre = "Developer";
        }
    }
}