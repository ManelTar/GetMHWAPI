namespace GetMHWAPI
{
    partial class FormAPI
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
            this.buttonLlamar = new System.Windows.Forms.Button();
            this.labelAPI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLlamar
            // 
            this.buttonLlamar.Location = new System.Drawing.Point(311, 273);
            this.buttonLlamar.Name = "buttonLlamar";
            this.buttonLlamar.Size = new System.Drawing.Size(172, 52);
            this.buttonLlamar.TabIndex = 0;
            this.buttonLlamar.Text = "Llamar API";
            this.buttonLlamar.UseVisualStyleBackColor = true;
            this.buttonLlamar.Click += new System.EventHandler(this.buttonLlamar_Click);
            // 
            // labelAPI
            // 
            this.labelAPI.AutoSize = true;
            this.labelAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelAPI.Location = new System.Drawing.Point(313, 65);
            this.labelAPI.Name = "labelAPI";
            this.labelAPI.Size = new System.Drawing.Size(157, 37);
            this.labelAPI.TabIndex = 1;
            this.labelAPI.Text = "API MHW";
            // 
            // FormAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAPI);
            this.Controls.Add(this.buttonLlamar);
            this.Name = "FormAPI";
            this.Text = "APIMHW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLlamar;
        private System.Windows.Forms.Label labelAPI;
    }
}

