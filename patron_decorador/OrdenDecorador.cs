using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_decorador
{
    public class OrdenDecorador:IOrden
    {
        IOrden _orden;
        protected double _costo=0.0;
        public OrdenDecorador(IOrden orden)
        {
            _orden=orden;
        }
        public double ObtenerCosto(){
            return _orden.ObtenerCosto()+_costo;
        }
    }
}