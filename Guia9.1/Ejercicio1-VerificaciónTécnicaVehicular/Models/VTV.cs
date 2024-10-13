using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class VTV : IComparable
    {
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        private DateTime fechaVenc;
        public DateTime FechaVencimiento
        {
            get
            {
                int contDH = 0; //contador de días hábiles
                DateTime fechaAct = Fecha;
                if (Aprobacion == TipoAprobacion.Parcial)
                {
                    while (contDH < 20)
                    {
                        if (fechaAct.DayOfWeek != DayOfWeek.Saturday || fechaAct.DayOfWeek != DayOfWeek.Sunday)
                        {
                            contDH++;
                            fechaAct.AddDays(1);
                        }
                        fechaAct.AddDays(1);
                    }
                    return fechaAct;
                }
                if (Aprobacion == TipoAprobacion.Aprobado)
                {
                    return fechaAct.AddYears(1);
                }
                else
                {
                    fechaAct = DateTime.MinValue;
                    return fechaAct;
                }
            }
        }
        public int CantidadEvaluaciones
        {
            get
            {
                return evaluaciones.Count();
            }
        }
        List<Evaluacion> evaluaciones = new List<Evaluacion>();
        public TipoAprobacion Aprobacion { get; private set; }
        public Propietario Propietario { get; private set; }
        public Evaluacion this[int idx]
        {
            get
            {
                return evaluaciones[idx]; 
            }
            set
            {
                evaluaciones[idx] = value;
            }
        }

        public int CompareTo(object obj)
        {
            VTV prop = obj as VTV;
            if (prop != null)
            {
                return this.Propietario.DNI.CompareTo(prop.Propietario.DNI);
            }
            return 1;
        }

        public VTV(string patente, Propietario propietario, DateTime fecha)
        {
            if(Regex.Match(patente.Replace(" ", ""), @"^(?:[A-Z]{3}\d{3}|[A-Z]{2}\d{3}[A-Z]{2})$").Success)
                /* Comento la expresión: inicio y fin de cadena son ^ y $ respectivamente.
                 * (?: ) la expresión que está dentro de los paréntesis representa un 
                 * grupo no capturante; es decir, la cadena puede coincidir con cualquiera
                 * de las expresiones regulares definidas. 
                 * \d representa cualquier dígito numérico (equivalente a [0-9])
                 * | representa que se está definiendo otra expresión diferente a la anterior
                 * {2}{3} representa número de apariciones de cada caracter.
                 */
            {
                Patente = patente;
                Propietario = propietario;
                Fecha = fecha;
            }
            else
            {
                throw new PatenteNoValidaException();
            }
        }

        public string[] EmitirComprobante()
        {
            string[] c = new string[CantidadEvaluaciones + 2];
            c[0] = $"Patente: {Patente}";
            c[1] = $"Fecha: {Fecha}";
            for (int i = 0; i < CantidadEvaluaciones - 1; i++)
            {
                c[i] = evaluaciones[i].ToString();
                //polimorfismo acá
            }
            return c;
        }

        public override string ToString() // esta vez le agregué una cierta lógica al ToString().
        {
            if (FechaVencimiento == DateTime.MinValue) //checkeo la fecha de vencimiento para mostrar
            {
                return $"Patente: {Patente}\r\nAprobacion: {Aprobacion}\r\nDNI: {Propietario.DNI}\r\nFecha: {Fecha}\r\nFecha Vencimiento: -\r\n\r\n";
            }
            return $"Patente: {Patente}\r\nAprobacion: {Aprobacion}\r\nDNI: {Propietario.DNI}\r\nFecha: {Fecha}\r\nFecha Vencimiento: {FechaVencimiento}\r\n\r\n";
        }

        public void AgregarEvaluacion(Evaluacion eva)
        {
            evaluaciones.Add(eva);
        }
    }
}
