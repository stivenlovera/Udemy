namespace patron_proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProxyPersona persona=new ProxyPersona(new Persona(10));
            System.Console.WriteLine($"esta persona esta: {persona.Eat()}");
        }
    }
}