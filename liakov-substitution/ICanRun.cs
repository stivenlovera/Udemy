namespace liakov_subtitution
{
    public interface ICanRun : IAnimal
    {
        void run()
        {
            Console.WriteLine("puede correr");
        }
    }
}