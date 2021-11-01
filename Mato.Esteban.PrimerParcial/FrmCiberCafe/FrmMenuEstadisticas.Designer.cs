
namespace FrmCiberCafe
{
    partial class FrmMenuEstadisticas
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
            this.cmbListaEstadisticas = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.rtbEstadistica = new System.Windows.Forms.RichTextBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbListaEstadisticas
            // 
            this.cmbListaEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbListaEstadisticas.FormattingEnabled = true;
            this.cmbListaEstadisticas.Items.AddRange(new object[] {
            "Lista de computadoras ordenadas por minutos de uso",
            "Lista de cabinas ordenadas por minutos de uso",
            "Ganancias totales y clasificadas por servicio (teléfono/computadora)",
            "Horas totales y la recaudación por tipo de llamada",
            "El software más pedido por los clientes",
            "El periférico más pedido por los clientes",
            "El juego más pedido por los clientes"});
            this.cmbListaEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.cmbListaEstadisticas.Name = "cmbListaEstadisticas";
            this.cmbListaEstadisticas.Size = new System.Drawing.Size(338, 23);
            this.cmbListaEstadisticas.TabIndex = 0;
            this.cmbListaEstadisticas.Text = "Lista de computadoras ordenadas por minutos de uso";
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVer.Location = new System.Drawing.Point(439, 12);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // rtbEstadistica
            // 
            this.rtbEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEstadistica.Location = new System.Drawing.Point(12, 63);
            this.rtbEstadistica.Name = "rtbEstadistica";
            this.rtbEstadistica.Size = new System.Drawing.Size(521, 277);
            this.rtbEstadistica.TabIndex = 2;
            this.rtbEstadistica.Text = "";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Location = new System.Drawing.Point(382, 10);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(30, 26);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // FrmMenuEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 352);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.rtbEstadistica);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cmbListaEstadisticas);
            this.MinimumSize = new System.Drawing.Size(561, 391);
            this.Name = "FrmMenuEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListaEstadisticas;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.RichTextBox rtbEstadistica;
        private System.Windows.Forms.Button btnAyuda;
    }
}