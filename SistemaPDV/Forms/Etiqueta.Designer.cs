namespace Sistema.Forms
{
    partial class Etiqueta
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
            this.etiquetas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // etiquetas
            // 
            this.etiquetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etiquetas.LocalReport.ReportEmbeddedResource = "Sistema.Forms.imprimeEtiqueta.rdlc";
            this.etiquetas.Location = new System.Drawing.Point(0, 0);
            this.etiquetas.Name = "etiquetas";
            this.etiquetas.ServerReport.BearerToken = null;
            this.etiquetas.Size = new System.Drawing.Size(800, 450);
            this.etiquetas.TabIndex = 0;
            // 
            // Etiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetas);
            this.Name = "Etiqueta";
            this.Text = "Etiqueta";
            this.Load += new System.EventHandler(this.Etiqueta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer etiquetas;
    }
}