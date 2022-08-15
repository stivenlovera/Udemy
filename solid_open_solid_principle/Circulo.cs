namespace solid_open_solid_principle
{
    public class Circulo:Ishape
    {
        public double Radius{ get;set;}
        public string Area(){
            return "El area Radio: " + Radius;
        }
        public bool valid(){
            return true;
        }
    }
}