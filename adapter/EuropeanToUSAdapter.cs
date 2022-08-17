using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public class EuropeanToUSAdapter : USPlugConnector
    {
        private IEuropeanPlugConnector _europeanPlugConnector;
        public EuropeanToUSAdapter(IEuropeanPlugConnector europeanPlugConnector)
        {
            this._europeanPlugConnector = europeanPlugConnector;
        }
        public string ProvideElectricity()
        {
            System.Console.WriteLine(this._europeanPlugConnector.GivenElectricity());
            return "";
        }
    }
}