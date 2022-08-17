using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_brigde
{
    public class Email : ITipoContacto
    {
        public string tipo => "email";
    }
}