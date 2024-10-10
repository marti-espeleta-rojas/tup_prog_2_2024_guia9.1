using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    internal class EmailNoValidoException : ApplicationException
    {
        public EmailNoValidoException(): base("Error: Email no válido") { }
        public EmailNoValidoException(string msg) : base(msg) { }
        public EmailNoValidoException(string msg, Exception exc) : base(msg, exc) { }
    }
}
