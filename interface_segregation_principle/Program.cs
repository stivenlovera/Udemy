namespace interface_segregation_principle
{
     class Program
    {
        static void Main(string[] args)
        {
            Car sedan= new Car(); 
            Console.WriteLine($"este vehiculo sedan tiene {sedan.GetNumberOfWheel()}");
        }
    }
}