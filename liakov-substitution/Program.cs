namespace liakov_subtitution
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanRun animal = new Dog();
            animal.Nombre = "Bravo";
            animal.Noise = "wao wao";
            animal.run();

            ICanFly ave = new Bird();
            animal.Nombre = "Loro";
            ave.Noise = "PIO PIO";
            ave.Fly();
            
            Console.ReadLine();
        }
    }
}