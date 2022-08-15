namespace liakov_subtitution
{
    public class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public string Noise { get; set; }
        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}