using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class EvaluacionParametrica : Evaluacion
    {
        public double ValorMinimo { get; private set; }
        public double ValorMaximo { get; private set; }
        public string Unidad { get; private set; }
        public double ValorTolerado { get; private set; }
        public double ValorMedido { get; set; }
        public EvaluacionParametrica(string nombre, string descripcion, double minimo, double maximo, string unidad, double tolerado): base(nombre, descripcion)
        {
            ValorMinimo = minimo;
            ValorMaximo = maximo;
            Unidad = unidad;
            ValorTolerado = tolerado;
            ValorMedido = ValorMaximo - ValorMinimo;
        }
        public override TipoAprobacion Evaluar()
        {
            if (ValorMedido < 0) return TipoAprobacion.NoValido;
            if (ValorMedido == 30)
            {
                return TipoAprobacion.Aprobado;
            }
            if (ValorMedido >= 21)
            {
                return TipoAprobacion.Parcial;
            }
            else
            {
                return TipoAprobacion.NoAprobado;
            }
        }
        public override string ToString()
        {
            return base.ToString()+$"\r\nUnidad: {Unidad}\r\nTipo Evaluación: {Evaluar()}\r\nValor Tolerado: {ValorTolerado}";
        }
    }
}
