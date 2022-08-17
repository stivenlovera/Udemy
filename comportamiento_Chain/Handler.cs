using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comportamiento_Chain
{
    public abstract class Handler
    {
        protected Handler _sucesor;
        public void CargarSucesor(Handler sucesor)
        {
            this._sucesor = sucesor;
        }
        public abstract string HandlerEntrada(Documento documento);
    }
}