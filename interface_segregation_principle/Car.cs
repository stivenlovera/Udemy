namespace interface_segregation_principle
{
    public class Car : IVehicle
    {
        public int GetNumberOfWheel()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo");
        }

        public void startEngine()
        {
            Console.WriteLine("start");
        }

        public void stopEngine()
        {
            Console.WriteLine("stop");
        }
    }
}