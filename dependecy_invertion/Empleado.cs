namespace dependecy_invertion
{
    public class Empleado
    {
        private List<IMensaje> _mensaje;

        public Empleado(List<IMensaje> mensaje)
        {
            _mensaje = mensaje;
        }
        public void enviar()
        {
            foreach (var mensaje in _mensaje)
            {
                mensaje.envia_mensaje();
            }
        }
    }
}