using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class Propietario
    {
        private int dni;
        private string email;
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                if (value>1000000)
                {
                    dni = value;
                }
                else 
                {
                    throw new DNINoValidoException("Error: DNI no válido. Ingrese nuevamente el DNI");
                }
            }
        }
        public string ApellidosNombre { get; set; }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if(Regex.Match(value, @"^[^@\s]+@[^@\s]+\.[a-z]{2,}$", RegexOptions.IgnoreCase).Success)
                {
                    email = value;
                }
                else
                {
                    throw new EmailNoValidoException();
                }
            }
        }
        public Propietario(int dni, string apynom, string email)
        {
            DNI = dni;
            Email = email;
            ApellidosNombre = apynom;
        }
        public override string ToString()
        {
            return $"DNI: {DNI}\r\nApellidos y Nombre: {ApellidosNombre}\r\nEmail: {Email}";
        }
    }
}
