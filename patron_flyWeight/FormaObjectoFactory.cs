using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_flyWeight
{
    public class FormaObjectoFactory
    {
        public Dictionary<string, IForma> formas = new Dictionary<string, IForma>();
        
        public int TotalObjetoCreado
        {
            get
            {
                return formas.Count;
            }
        }
        public IForma optenerForma(string nombreForma)
        {
            IForma forma = null;
            if (formas.ContainsKey(nombreForma))
            {
                forma = formas[nombreForma];
            }
            else
            {
                switch (nombreForma)
                {
                    case "Rectangulo":
                        forma =new Rectangulo();
                        formas.Add("Rectangulo", forma);
                        break;
                    case "Circulo":
                        forma =new Circulo();
                        formas.Add("Circulo", forma);
                        break;
                    default:
                        throw new Exception("FACTORY NO FUE CREADO ESPECIFIQUE UN OBJETO");
                }
            }
            return forma;
        }
    }
}