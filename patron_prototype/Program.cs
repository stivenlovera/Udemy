namespace patron_prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Producto producto= new Producto();
            producto.nombre="carro rojo";
            producto.precio.cantidad=100;
            Console.WriteLine($"E precio es {producto.DeepCopy()}");
        }
    }
    public class Producto
    {
        public string nombre { get; set; }
        public Precio precio { get; set; }
        public Producto DeepCopy()
        {
            return new Producto { nombre = nombre, precio = new Precio(precio) };
        }
    }

    public class Precio
    {
        public double cantidad { get; set; }
        public Precio() { }
        public Precio(Precio precio)
        {
            cantidad = precio.cantidad;
        }
    }
}

