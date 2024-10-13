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
            try
            {
                #region Leyendo de TextBox's
                int i = 0;
                string patente = tbPatente.Text;
                int dni = Convert.ToInt32(tbDNI.Text);
                string email = tbCorreo.Text;
                string apynom = tbApellidosYNombres.Text;
                DateTime fecha = dateTimeHoy.Value.ToUniversalTime();
                #endregion
                #region Instanciando objetos
                propietario = new Propietario(dni, apynom, email);
                vtv = fiscalizador.AgregarVTV(patente, propietario, fecha);
                #endregion
                #region Desactivando botones y demás porque hardcodeo
                FormEvaluacion evalu = new FormEvaluacion();
                evalu.groupBox2.Enabled = false;
                evalu.dmdDescripcionEvaluacion.Text = "";
                evalu.domainUpDown1.Text = "";
                evalu.tbMaximo.Enabled = false;
                evalu.tbMinimo.Enabled = false;
                evalu.tbValorMedido.Enabled = false;
                #endregion
                #region Hardcodeo datos y agrego evaluaciones
                if (evalu.ShowDialog() == DialogResult.OK)
                //iría un while para que vuelva "preguntar", pero como esta harcodeado le pongo if
                {
                    MessageBox.Show("Ha cargado su evaluación con éxito.\r\nHaga click en siguiente para cargar más o cierre para salir");
                    evalu.dmdDescripcionEvaluacion.Text = "";
                    evalu.domainUpDown1.Text = "";
                    eva = new EvaluacionParametrica("Prueba de frenos delanteros", "Porcentaje de diferencia de frenado entre ejes", 0, 30, "Porcentaje", 23);
                    vtv.AgregarEvaluacion(eva);
                    eva = new EvaluacionParametrica("Prueba de frenos Traseros", "Porcentaje de diferencia de frenado entre ejes", 0, 30, "Porcentaje", 21);
                    vtv.AgregarEvaluacion(eva);
                    eva = new EvaluacionParametrica("Alineación", "Convergencia en grados", 0, 0.5, "Grado", 0.1);
                    vtv.AgregarEvaluacion(eva);
                    eva = new EvaluacionParametrica("Luces de corto alcance", "Intensidad lumínica", 10000, 15000, "Candela", 14600);
                    vtv.AgregarEvaluacion(eva);
                    eva = new EvaluacionParametrica("Luces de largo alcance", "Intensidad lumínica", 30000, 40000, "Candela", 35200);
                    vtv.AgregarEvaluacion(eva);
                    eva = new EvaluacionSimple("Bocina", "Funcionamiento correcto", false);
                    vtv.AgregarEvaluacion(eva);
                }
                #endregion
                #region Muestro el comprobante en FormVer
                FormVer ver = new FormVer();
                foreach (string s in vtv.EmitirComprobante())
                {
                    ver.tbVer.Text += s;
                }
                ver.ShowDialog();
                #endregion
            }

            catch (DNINoValidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EmailNoValidoException em)
            {
                MessageBox.Show(em.Message);
            }
            catch (PatenteNoValidaException pt)
            {
                MessageBox.Show(pt.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #region Limpiando TextBox's
            tbApellidosYNombres.Clear();
            tbDNI.Clear();
            tbCorreo.Clear();
            tbPatente.Clear();
            #endregion

        }

        private void btnVerVTVRealizados_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();
            List<VTV> vtvs = fiscalizador.OrdenarVTVsPorDNIPropietario();
            foreach(VTV v in vtvs)
            {
                ver.tbVer.Text += v.ToString();
            }
            ver.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List <VTV> lista = new List<VTV>();
            string patente = tbPatente.Text;
            foreach (VTV pat in fiscalizador.vtvs)
            {
                if(pat.Patente == patente)
                {
                    lista.Add(pat);
                }
            }
            lista.Sort();
            FormVer fver = new FormVer();
            foreach (VTV v in lista)
            {
                fver.tbVer.Text += v.ToString();
            }
            fver.ShowDialog();
            tbPatente.Clear();
        }
    }
}
