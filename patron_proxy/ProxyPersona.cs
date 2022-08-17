using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_proxy
{
    public class ProxyPersona
    {
        private readonly Persona _persona;
        public ProxyPersona(Persona persona)
        {
            _persona = persona;
        }
        public string Eat()
        {
            if (_persona.Balance > 0)
                return _persona.Comer();
            return "no tiene dinero";
        }
    }
}