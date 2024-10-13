namespace Ejercicio1_VerificaciónTécnicaVehicular
{
    partial class FormEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Porcentaje = new System.Windows.Forms.Label();
            this.tbValorMedido = new System.Windows.Forms.TextBox();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.tbMinimo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFuncionamientoCorrect = new System.Windows.Forms.CheckBox();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.dmdDescripcionEvaluacion = new System.Windows.Forms.DomainUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Prueba de frenos delanteros");
            this.domainUpDown1.Items.Add("Prueba de frenos traseros");
            this.domainUpDown1.Items.Add("Alineación");
            this.domainUpDown1.Items.Add("Luces de corto alcance");
            this.domainUpDown1.Items.Add("Luces de largo alcance");
            this.domainUpDown1.Items.Add("Bocina");
            this.domainUpDown1.Location = new System.Drawing.Point(119, 22);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "dmdNombreEvaluacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Porcentaje);
            this.groupBox1.Controls.Add(this.tbValorMedido);
            this.groupBox1.Controls.Add(this.tbMaximo);
            this.groupBox1.Controls.Add(this.tbMinimo);
            this.groupBox1.Location = new System.Drawing.Point(42, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluación Paramétrica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valor Medido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Máximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mínimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valores";
            // 
            // Porcentaje
            // 
            this.Porcentaje.AutoSize = true;
            this.Porcentaje.Location = new System.Drawing.Point(517, 49);
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Size = new System.Drawing.Size(58, 13);
            this.Porcentaje.TabIndex = 3;
            this.Porcentaje.Text = "Porcentaje";
            // 
            // tbValorMedido
            // 
            this.tbValorMedido.Location = new System.Drawing.Point(400, 49);
            this.tbValorMedido.Name = "tbValorMedido";
            this.tbValorMedido.Size = new System.Drawing.Size(100, 20);
            this.tbValorMedido.TabIndex = 2;
            // 
            // tbMaximo
            // 
            this.tbMaximo.Enabled = false;
            this.tbMaximo.Location = new System.Drawing.Point(249, 50);
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.Size = new System.Drawing.Size(100, 20);
            this.tbMaximo.TabIndex = 1;
            this.tbMaximo.Text = "30";
            // 
            // tbMinimo
            // 
            this.tbMinimo.Enabled = false;
            this.tbMinimo.Location = new System.Drawing.Point(97, 50);
            this.tbMinimo.Name = "tbMinimo";
            this.tbMinimo.Size = new System.Drawing.Size(100, 20);
            this.tbMinimo.TabIndex = 0;
            this.tbMinimo.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFuncionamientoCorrect);
            this.groupBox2.Location = new System.Drawing.Point(39, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluación Simple";
            // 
            // cbFuncionamientoCorrect
            // 
            this.cbFuncionamientoCorrect.AutoSize = true;
            this.cbFuncionamientoCorrect.Location = new System.Drawing.Point(217, 31);
            this.cbFuncionamientoCorrect.Name = "cbFuncionamientoCorrect";
            this.cbFuncionamientoCorrect.Size = new System.Drawing.Size(178, 17);
            this.cbFuncionamientoCorrect.TabIndex = 0;
            this.cbFuncionamientoCorrect.Text = "¿El funcionamiento es correcto?";
            this.cbFuncionamientoCorrect.UseVisualStyleBackColor = true;
            // 
            // btSiguiente
            // 
            this.btSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSiguiente.Location = new System.Drawing.Point(304, 287);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btSiguiente.TabIndex = 5;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            // 
            // dmdDescripcionEvaluacion
            // 
            this.dmdDescripcionEvaluacion.Items.Add("Porcentaje de diferencia de frenado entre ejes");
            this.dmdDescripcionEvaluacion.Items.Add("Convergencia en grados");
            this.dmdDescripcionEvaluacion.Items.Add("Intensidad lumínica");
            this.dmdDescripcionEvaluacion.Location = new System.Drawing.Point(119, 65);
            this.dmdDescripcionEvaluacion.Name = "dmdDescripcionEvaluacion";
            this.dmdDescripcionEvaluacion.Size = new System.Drawing.Size(120, 20);
            this.dmdDescripcionEvaluacion.TabIndex = 6;
            this.dmdDescripcionEvaluacion.Text = "domainUpDown2";
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 318);
            this.Controls.Add(this.dmdDescripcionEvaluacion);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown1);
            this.Name = "FormEvaluacion";
            this.Text = "FormEvaluacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Porcentaje;
        private System.Windows.Forms.CheckBox cbFuncionamientoCorrect;
        public System.Windows.Forms.DomainUpDown domainUpDown1;
        public System.Windows.Forms.DomainUpDown dmdDescripcionEvaluacion;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbMaximo;
        public System.Windows.Forms.TextBox tbMinimo;
        public System.Windows.Forms.TextBox tbValorMedido;
    }
}