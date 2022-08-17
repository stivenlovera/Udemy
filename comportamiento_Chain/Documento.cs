using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comportamiento_Chain
{
    public class Documento
    {
        public string Nombre { get; }
        public string Contenido { get; }
        public Documento(string nombre, string contenido)
        {
            this.Nombre = nombre;
            this.Contenido = contenido;
        }
    }
}