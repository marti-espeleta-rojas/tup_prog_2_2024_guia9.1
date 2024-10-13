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
        public List<VTV> vtvs = new List<VTV>();
        public string PlantillaComprobante { get; set; }
        public VTV this[int idx]
        {
            get
            {
                if (idx > vtvs.Count)
                {
                    throw new IndexOutOfRangeException("No existe la evaluación solicitada");
                }
                return vtvs[idx];
            }
        }
        public VTV AgregarVTV(string patente, Propietario propietario, DateTime fecha)
        {
            VTV vtv = new VTV(patente, propietario, fecha);
            vtvs.Add(vtv);
            return vtv;
        }

        public List<VTV> VerVTVPorPatente(string patente)
        {
            List<VTV> NuevaVtvs = null;
            //hago búsqueda secuencial para encontrar todas las ocurrencias
            for(int i = 0; i < CantidadVTV; i++)
            {
                if(patente == vtvs[i].Patente)
                {
                    NuevaVtvs.Add(vtvs[i]);
                }
            }

            return NuevaVtvs;
        }
        public List<VTV> OrdenarVTVsPorDNIPropietario()
        {
            vtvs.Sort();//por DNI de propietario
            return vtvs;
        }
    }
}
