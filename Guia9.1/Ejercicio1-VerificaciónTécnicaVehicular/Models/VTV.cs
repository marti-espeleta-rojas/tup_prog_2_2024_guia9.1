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
            if(Regex.Match(patente.Replace(" ", ""), @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$ | ^[A-Z]{3}[0-9]{3}$").Success)
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
                Aprobacion = evaluaciones[i].Evaluar();
                c[i] = Aprobacion.ToString() + evaluaciones[i].ToString();
                //polimorfismo acá
            }
            return c;
        }

        public void AgregarEvaluacion(Evaluacion eva)
        {
            evaluaciones.Add(eva);
        }
        public override string ToString()
        {
            return $"Patente: {Patente}\r\nFecha: {Fecha}";
        }
    }
}
