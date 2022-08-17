using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_brigde
{
    public class Empleados
    {
        public string Nombre { get; set; }
        private ITipoContacto _tipoContacto;
        public Empleados(ITipoContacto tipoContacto)
        {
            this._tipoContacto=tipoContacto;
        }
        public override string ToString()
        {
            return $"{Nombre} a sifo contactado por: {_tipoContacto.tipo}";
        }
    }
}