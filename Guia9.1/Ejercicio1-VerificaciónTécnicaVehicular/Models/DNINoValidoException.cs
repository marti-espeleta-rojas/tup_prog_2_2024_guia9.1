using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    internal class DNINoValidoException : ApplicationException
    {
        public DNINoValidoException() : base("DNI no válido") { }
        public DNINoValidoException(string msg) : base(msg) { }
        public DNINoValidoException(string msg, Exception exc) : base(msg, exc) { }
    }
}
