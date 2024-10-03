using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class EvaluacionSimple : Evaluacion
    {
        public bool HaVerificado { get; set; }
        public EvaluacionSimple(string nombre, string descripcion) : base(nombre, descripcion) { }
        public override TipoAprobacion Evaluar()
        {
            if (HaVerificado)
            {
                return TipoAprobacion.NoAprobado;
            }
            return TipoAprobacion.Aprobado;
        }
        public override string ToString()
        {
            if (HaVerificado)
                return base.ToString() + "Aprobado";
            else return base.ToString() + "No Aprobado";
        }


    }
}
