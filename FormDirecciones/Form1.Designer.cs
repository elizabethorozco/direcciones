namespace FormDirecciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIp1 = new System.Windows.Forms.MaskedTextBox();
            this.txtIp2 = new System.Windows.Forms.MaskedTextBox();
            this.txtIp3 = new System.Windows.Forms.MaskedTextBox();
            this.txtIp4 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion Ip";
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.Location = new System.Drawing.Point(137, 112);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(114, 30);
            this.btnDiagnostico.TabIndex = 2;
            this.btnDiagnostico.Text = "Diagnosticar Ip";
            this.btnDiagnostico.UseVisualStyleBackColor = true;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = ".";
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(93, 56);
            this.txtIp1.Mask = "999";
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(48, 20);
            this.txtIp1.TabIndex = 9;
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(163, 56);
            this.txtIp2.Mask = "999";
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(48, 20);
            this.txtIp2.TabIndex = 10;
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(233, 56);
            this.txtIp3.Mask = "999";
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(48, 20);
            this.txtIp3.TabIndex = 11;
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(306, 56);
            this.txtIp4.Mask = "999";
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(48, 20);
            this.txtIp4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(369, 185);
            this.Controls.Add(this.txtIp4);
            this.Controls.Add(this.txtIp3);
            this.Controls.Add(this.txtIp2);
            this.Controls.Add(this.txtIp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtIp1;
        private System.Windows.Forms.MaskedTextBox txtIp2;
        private System.Windows.Forms.MaskedTextBox txtIp3;
        private System.Windows.Forms.MaskedTextBox txtIp4;
    }
}

