using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class VTV : IComparable
    {
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        public int CantidadEvaluaciones { get; set; }
        List<Evaluacion> verificaciones = new List<Evaluacion>();
        public Evaluacion this[int idx]
        {
            get
            {
                return verificaciones[idx]; 
            }
        }
        public TipoAprobacion Aprobacion { get; private set; }
        public Propietario Propietario { get; private set; }
        public int CompareTo(object obj)
        {
            VTV vtv = obj as VTV;
            if (vtv != null)
            {
                return Patente.CompareTo(vtv.Patente);
            }
            return 1;
        }
        public VTV(string patente, Propietario propietario)
        {
            Patente = patente;
            Propietario = propietario;
        }
        public string[] EmitirComprobante()
        {

        }
        public override string ToString()
        {
            return $"Patente: {Patente}\r\nFecha: {Fecha}";
        }
    }
}
