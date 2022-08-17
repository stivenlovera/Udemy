using System.Security.Cryptography;
namespace patron_decorador
{
    public class Program
    {
        static void Main(string[] args)
        {
             OrdenDecorador simpleOrden = new OrdenDecorador(new PremiumOrden(new SimpleOrden()));
             System.Console.WriteLine(simpleOrden.ObtenerCosto());
        }
    }
}