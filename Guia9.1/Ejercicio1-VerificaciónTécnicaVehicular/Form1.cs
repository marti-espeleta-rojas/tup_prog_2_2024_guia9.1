using Ejercicio1_VerificaciónTécnicaVehicular.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_VerificaciónTécnicaVehicular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VTV vtv = null;
        FiscalizadorVTV fiscalizador = new FiscalizadorVTV();
        Propietario propietario = null;
        Evaluacion eva = null;
        private void btnIniciarCarga_Click(object sender, EventArgs e)
        {
            int i = 0;
            string patente = tbPatente.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            string email = tbCorreo.Text;
            string apynom = tbApellidosYNombres.Text;
            DateTime fecha = dateTimeHoy.Value.ToUniversalTime();
            try
            {
                propietario = new Propietario(dni, apynom, email);
            }
            catch (DNINoValidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EmailNoValidoException em)
            {
                MessageBox.Show(em.Message);
            }
            try
            {
                fiscalizador.AgregarVTV(patente, propietario, fecha);
            }
            catch (PatenteNoValidaException pt)
            {
                MessageBox.Show(pt.Message);
            }

            FormEvaluacion evalu = new FormEvaluacion();
            while (evalu.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("Ha cargado su evaluación con éxito.\r\nHaga click en siguiente para cargar más o cierre la ventana para salir");
            }

            eva = new EvaluacionParametrica("Prueba de frenos delanteros", "Porcentaje de diferencia de frenado entre ejes", 0, 30, "Porcentaje", 23);
            vtv = fiscalizador[i++];
            vtv.AgregarEvaluacion(eva);
            eva = new EvaluacionParametrica("Prueba de frenos Traseros", "Porcentaje de diferencia de frenado entre ejes", 0, 30, "Porcentaje", 21);
            vtv = fiscalizador[i++];
            vtv.AgregarEvaluacion(eva);
            eva = new EvaluacionParametrica("Alineación", "Convergencia en grados", 0, 0.5, "Grado", 0.1);
            vtv = fiscalizador[i++];
            vtv.AgregarEvaluacion(eva);
            eva = new EvaluacionParametrica("Luces de corto alcance", "Intensidad lumínica", 10000, 15000, "Candela", 14600);
            vtv = fiscalizador[i++];
            vtv.AgregarEvaluacion(eva);
            eva = new EvaluacionParametrica("Luces de largo alcance", "Intensidad lumínica", 30000, 40000, "Candela", 35200);
            vtv = fiscalizador[i++];
            vtv.AgregarEvaluacion(eva);
            eva = new EvaluacionSimple("Bocina", "Funcionamiento correcto", false); 
            vtv = fiscalizador[i++];
            vtv.AgregarEvaluacion(eva);

            FormVer ver = new FormVer();
            foreach (string s in vtv.EmitirComprobante())
            {
                ver.tbVer.Text += s;
            }
        }
    }
}
