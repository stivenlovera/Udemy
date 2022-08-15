namespace liakov_subtitution
{

    public interface IAnimal
    {
        string Nombre { get; set; }
        string Noise { get; set; }
        void MakeNoise();
    }
}