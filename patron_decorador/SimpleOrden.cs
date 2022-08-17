using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_decorador
{
    public class SimpleOrden : IOrden
    {
        public double ObtenerCosto()
        {
            return 15;
        }
    }
}