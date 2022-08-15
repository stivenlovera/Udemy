namespace liakov_subtitution
{
    public class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine(" Puedo volar");
        }
    }
}