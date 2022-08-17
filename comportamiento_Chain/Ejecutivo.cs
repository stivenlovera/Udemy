using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comportamiento_Chain
{
    public class Ejecutivo : Handler
    {
        public override string HandlerEntrada(Documento documento)
        {
            if (documento.Contenido.Length < 10)
            {
                return $"Documento  {documento.Nombre} revisado por  {this.GetType().Name}";
            }
            else
            {
                if (_sucesor != null)
                {
                    return _sucesor.HandlerEntrada(documento);
                }
                return "";
            }

        }
    }
}