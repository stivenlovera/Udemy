namespace singelton
{
    class Program
    {
        /*
        *test
        */
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "test";
            System.Console.WriteLine($"esto es un ejemplo singleton {persona.Nombre}");
        }
    }
}