using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_brigde
{
    public class ScrumMaster: Empleados
    {
        public ScrumMaster(ITipoContacto tipoContacto) :base (tipoContacto){
            Nombre="es escrum";
        }
    }
}