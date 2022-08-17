using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_composite
{
    public class MiembroEquipo : Empleado
    {
        public MiembroEquipo(string nombre, int salario) : base(nombre, salario)
        {

        }
         public override void Add(Empleado empleado)
        {
      
        }
 
        public override void Remove(Empleado empleado)
        {
        }
 
        public override int GetCost()
        {
            return Salario;
        }

    }
}