namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EuropeanElectricalConnector generar=new EuropeanElectricalConnector();
            generar.GivenElectricity();
            System.Console.WriteLine($"el En ejecucion  {generar.GivenElectricity()}");
        }
    }
}