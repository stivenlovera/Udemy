using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public interface IEuropeanPlugConnector
    {
        string GivenElectricity();
    }
}