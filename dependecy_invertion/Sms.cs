namespace dependecy_invertion
{
    public class Sms:IMensaje
    {
        public string numeroTelefono { get; set; }
        public string mensaje { get; set; }
        public void envia_mensaje(){
            
        }
    }
}