using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VerificaciónTécnicaVehicular.Models
{
    public class FiscalizadorVTV
    {
        public int CantidadVTV { get; private set; }
        public List<VTV> verificaciones = new List<VTV>();
        public string PlantillaComprobante { get; set; }
        public VTV this[int idx]
        {
            get
            {
                return verificaciones[idx];
            }
        }
        public VTV AgregarVTV(string patente, Propietario propietario)
        {
            VTV vtv = new VTV(patente, propietario);
            verificaciones.Add(vtv);
            return vtv;
        }

        public List<VTV> VerVTVPorPatente(string patente)
        {
            verificaciones.Sort();
            List<VTV> vtvs = verificaciones.BinarySearch(patente);
            return verificaciones;
        }
    }
}
