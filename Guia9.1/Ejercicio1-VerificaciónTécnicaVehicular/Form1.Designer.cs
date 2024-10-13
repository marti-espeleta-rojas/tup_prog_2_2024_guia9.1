namespace Ejercicio1_VerificaciónTécnicaVehicular
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciarCarga = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimeHoy = new System.Windows.Forms.DateTimePicker();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbApellidosYNombres = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerVTVRealizados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIniciarCarga);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro VTV";
            // 
            // btnIniciarCarga
            // 
            this.btnIniciarCarga.Location = new System.Drawing.Point(223, 282);
            this.btnIniciarCarga.Name = "btnIniciarCarga";
            this.btnIniciarCarga.Size = new System.Drawing.Size(117, 23);
            this.btnIniciarCarga.TabIndex = 2;
            this.btnIniciarCarga.Text = "Iniciar Carga VTV";
            this.btnIniciarCarga.UseVisualStyleBackColor = true;
            this.btnIniciarCarga.Click += new System.EventHandler(this.btnIniciarCarga_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.dateTimeHoy);
            this.groupBox3.Controls.Add(this.tbPatente);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 116);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Vehículo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(329, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimeHoy
            // 
            this.dateTimeHoy.Location = new System.Drawing.Point(123, 78);
            this.dateTimeHoy.Name = "dateTimeHoy";
            this.dateTimeHoy.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHoy.TabIndex = 3;
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(123, 28);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(200, 20);
            this.tbPatente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Hoy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCorreo);
            this.groupBox2.Controls.Add(this.tbApellidosYNombres);
            this.groupBox2.Controls.Add(this.tbDNI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Propietario";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(166, 96);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(199, 20);
            this.tbCorreo.TabIndex = 5;
            // 
            // tbApellidosYNombres
            // 
            this.tbApellidosYNombres.Location = new System.Drawing.Point(166, 61);
            this.tbApellidosYNombres.Name = "tbApellidosYNombres";
            this.tbApellidosYNombres.Size = new System.Drawing.Size(199, 20);
            this.tbApellidosYNombres.TabIndex = 4;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(166, 31);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(199, 20);
            this.tbDNI.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellidos y Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI";
            // 
            // btnVerVTVRealizados
            // 
            this.btnVerVTVRealizados.Location = new System.Drawing.Point(616, 23);
            this.btnVerVTVRealizados.Name = "btnVerVTVRealizados";
            this.btnVerVTVRealizados.Size = new System.Drawing.Size(103, 61);
            this.btnVerVTVRealizados.TabIndex = 1;
            this.btnVerVTVRealizados.Text = "Ver VTV Realizados";
            this.btnVerVTVRealizados.UseVisualStyleBackColor = true;
            this.btnVerVTVRealizados.Click += new System.EventHandler(this.btnVerVTVRealizados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 334);
            this.Controls.Add(this.btnVerVTVRealizados);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIniciarCarga;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerVTVRealizados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbApellidosYNombres;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeHoy;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Button btnBuscar;
    }
}

