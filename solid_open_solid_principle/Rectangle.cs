namespace solid_open_solid_principle
{
    class Rectangle : Ishape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Area()
        {
            return "El area Rectangulo: " + Width * Height;
        }

        public bool valid()
        {
            return true;
        }
    }
}