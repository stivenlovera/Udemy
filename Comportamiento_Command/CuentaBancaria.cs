using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comportamiento_Command
{
    public class CuentaBancaria
    {
        public int Balance { get; set; }
        public void Ejecutar(Command c)
        {
            switch (c.BalanceAction)
            {
                case Action.Depositar:
                    Balance += c.Cantidad;
                    c.Estado = true;
                    break;
                case Action.Retirar:
                    c.Estado = Balance >= c.Cantidad;
                    if (c.Estado) Balance -= c.Cantidad;
                    break;

                default:
                    break;
            }
        }
    }
}