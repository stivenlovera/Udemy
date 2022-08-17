using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comportamiento_Command
{
    public class Command
    {
        public Action BalanceAction;
        public int Cantidad;
        public bool Estado;
    }
}