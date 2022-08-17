using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patron_proxy
{
    public class Persona
    {
        public int Balance { get; set; }
        public Persona(int balance)
        {
            Balance=balance;
        }
        public string Comer(){
            return "comiendo";
        }
    }
}