using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_composite
{
    public class JefeEquipo:Empleado
    {
        List<Empleado> _empleados=new List<Empleado>();
        public JefeEquipo(string nombre) : base(nombre, 0)
        {
            
        }
        public override void Add(Empleado empleado)
        {
            _empleados.Add(empleado);
        }
 
        public override int GetCost()
        {
            return _empleados.Sum(o => o.Salario);
        }
 
        public override void Remove(Empleado empleado)
        {
            _empleados.Remove(empleado);
        }
    }
    
}