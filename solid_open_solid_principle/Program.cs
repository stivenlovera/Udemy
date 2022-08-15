namespace solid_open_solid_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaCalculator = new AreaCalculator();
            var shapes = new List<Ishape>()
        {
                new Rectangle { Width = 40, Height = 20},
                new Circulo {Radius = 10}
        };
            Console.WriteLine(areaCalculator.Area(shapes));
        }
    }
}