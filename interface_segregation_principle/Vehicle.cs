namespace interface_segregation_principle
{
    public class Bicycle : IVehicle
    {
        public int GetNumberOfWheel()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo");
        }
        
    }
}
