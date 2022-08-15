using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace patron_factory
{
    public class Program
    {

    }
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Estudiante(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        
    }
    public static class EstudianteFactory
        {
            private static int id = 100;
            public static Estudiante Create(string nombre)
            {
                return new Estudiante(id++, nombre);
            }

        }
}