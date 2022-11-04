namespace A
{
    partial class AltaFamilia
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
            this.btCerrar = new System.Windows.Forms.Button();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtParentesco = new System.Windows.Forms.TextBox();
            this.TxtOcupacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(135, 269);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 0;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(247, 269);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtAceptar.TabIndex = 1;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parentesco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ocupacion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(135, 20);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(187, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(135, 71);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(187, 20);
            this.TxtApellido.TabIndex = 7;
            // 
            // TxtParentesco
            // 
            this.TxtParentesco.Location = new System.Drawing.Point(135, 122);
            this.TxtParentesco.Name = "TxtParentesco";
            this.TxtParentesco.Size = new System.Drawing.Size(187, 20);
            this.TxtParentesco.TabIndex = 8;
            // 
            // TxtOcupacion
            // 
            this.TxtOcupacion.Location = new System.Drawing.Point(135, 176);
            this.TxtOcupacion.Name = "TxtOcupacion";
            this.TxtOcupacion.Size = new System.Drawing.Size(187, 20);
            this.TxtOcupacion.TabIndex = 9;
            // 
            // AltaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 317);
            this.Controls.Add(this.TxtOcupacion);
            this.Controls.Add(this.TxtParentesco);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.btCerrar);
            this.Name = "AltaFamilia";
            this.Text = "AltaFamilia";
            this.Load += new System.EventHandler(this.AltaFamilia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtParentesco;
        private System.Windows.Forms.TextBox TxtOcupacion;
    }
}