using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_composite
{
    public abstract class Empleado
    {
        public string Nombre { get; private set; }
        public int Salario { get; private set; }
        protected Empleado(string nombre, int salary)
        {
            this.Nombre = nombre;
            this.Salario = salary;
        }
        public abstract void Add(Empleado empleado);
        public abstract void Remove(Empleado empleado);

        public abstract int GetCost();
    }
}