using System.Security.Cryptography;
namespace patron_facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            EjecutarApp ejecutar = new EjecutarApp();

            System.Console.WriteLine("iniciando...");
            ejecutar.Iniciar();
            ejecutar.Completado();
        }
    }
}