
namespace A
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
            this.btCompletar = new System.Windows.Forms.Button();
            this.dgvFamilia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // btCompletar
            // 
            this.btCompletar.Location = new System.Drawing.Point(664, 381);
            this.btCompletar.Name = "btCompletar";
            this.btCompletar.Size = new System.Drawing.Size(75, 23);
            this.btCompletar.TabIndex = 0;
            this.btCompletar.Text = "Completar";
            this.btCompletar.UseVisualStyleBackColor = true;
            this.btCompletar.Click += new System.EventHandler(this.btCompletar_Click);
            // 
            // dgvFamilia
            // 
            this.dgvFamilia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilia.Location = new System.Drawing.Point(41, 42);
            this.dgvFamilia.Name = "dgvFamilia";
            this.dgvFamilia.Size = new System.Drawing.Size(511, 409);
            this.dgvFamilia.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.dgvFamilia);
            this.Controls.Add(this.btCompletar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCompletar;
        private System.Windows.Forms.DataGridView dgvFamilia;
    }
}

