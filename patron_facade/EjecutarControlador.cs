using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_facade
{
    public class EjecutarControlador
    {
        public static bool EstaEncendido { get; private set; }
        public void TurnoEncendido() => EstaEncendido = true;
        public void TurnoApagado() => EstaEncendido = false;
    }
}