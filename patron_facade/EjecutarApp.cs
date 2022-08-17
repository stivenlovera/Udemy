using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_facade
{
    public class EjecutarApp
    {
        private MusicaControlador _musica_controlador = new MusicaControlador();
        private EjecutarControlador _ejecutarControlador = new EjecutarControlador();

        public void Iniciar()
        {
            _musica_controlador.TurnoEncendido();
            _ejecutarControlador.TurnoEncendido();
            System.Console.WriteLine("encendiendo");
        }
        public void Completado()
        {
            _musica_controlador.TurnoApagado();
            _ejecutarControlador.TurnoApagado();
                System.Console.WriteLine("apagando");
        }
    }
}