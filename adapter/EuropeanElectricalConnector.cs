using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public class EuropeanElectricalConnector: IEuropeanPlugConnector
    {
        public string GivenElectricity(){
            return "dando energia";
        }
    }
}