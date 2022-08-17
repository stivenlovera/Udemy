namespace patron_flyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            FormaObjectoFactory forma = new FormaObjectoFactory();
            System.Console.WriteLine($" resultado {forma.optenerForma("Rectangulo")}");
        }
    }
}