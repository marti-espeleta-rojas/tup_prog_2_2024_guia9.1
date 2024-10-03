using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class Propietario
    {
        public int DNI { get; private set; }
        public string ApellidosNombre { get; set; }
        public string Email { get; set; }
        public Propietario(int dni, string apynom, string email)
        {
            DNI = dni;
            Email = email;
            ApellidosNombre = apynom;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
