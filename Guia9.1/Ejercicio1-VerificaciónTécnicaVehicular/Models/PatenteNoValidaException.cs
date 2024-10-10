using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class PatenteNoValidaException : ApplicationException
    {
        public PatenteNoValidaException(string msg):base(msg) { }
        public PatenteNoValidaException():base("Error: formato de patente no válido") { }
        public PatenteNoValidaException(string msg, Exception exc) : base(msg, exc) { }
    }
}
