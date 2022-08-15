namespace solid_open_solid_principle
{
    class AreaCalculator
    {
        public string Area(List<Ishape> shapes)
        {
            string area = "";
            foreach (var shape in shapes)
            {
                area += shape.Area();
                area += shape.Descripcion();
                area += Environment.NewLine;
            }
            return area;
        }
    }
}