using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_decorador
{
    public class PremiumOrden:OrdenDecorador
    {
        public PremiumOrden(IOrden orden): base(orden)
        {
            _costo=10;
        }
    }
}