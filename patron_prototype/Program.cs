namespace patron_prototype
{
    public class Program
    {
        Producto producto=new Producto();
        producto.nombre="test";
    }
    public class Producto
    {
        public string nombre { get; set; }
        public Precio precio { get; set; }

        public Producto DeepCopy()
        {
            return new Producto{ nombre = nombre, precio = new Precio(precio) };
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
    
}