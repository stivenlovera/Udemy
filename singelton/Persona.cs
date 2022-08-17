using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace singelton
{
    public class Persona
    {
        public string Nombre { get; set; }
        public static Persona instancia = new Persona();
        public static Persona Instancia => instancia;
    }
}