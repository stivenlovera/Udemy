using System.Net;
namespace patron_builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card auto=new Card();
            auto.nombre=("sedan");
            auto.modelo=("corrola");
            Console.WriteLine(auto.ToString());
        }
    }
    public sealed class Card
    {
        public string nombre;
        public string modelo;

        public override string ToString()
        {
            return $"Mi automovil es {nombre}, modelo {modelo}";
        }
    }
    public class CardBuilder
    {
        private readonly Card _Car;
        public CardBuilder()
        {
            _Car = new Card();
        }
        public static CardBuilder CreateNuevo()
        {
            return new CardBuilder();
        }
        public CardBuilder addNombre(string nombre)
        {
            _Car.nombre = nombre;
            return this;
        }
        public CardBuilder addModelo(string modelo)
        {
            _Car.modelo = modelo;
            return this;
        }
        public Card build()
        {
            return _Car;
        }
    }
}