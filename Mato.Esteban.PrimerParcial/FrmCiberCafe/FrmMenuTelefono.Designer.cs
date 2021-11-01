
namespace FrmCiberCafe
{
    partial class FrmMenuTelefono
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
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.lblGuion1 = new System.Windows.Forms.Label();
            this.lblGuion2 = new System.Windows.Forms.Label();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.lblCodArea = new System.Windows.Forms.Label();
            this.lblPrefijo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblTelefonoDisponible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrefijo.Location = new System.Drawing.Point(79, 56);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(40, 29);
            this.txtPrefijo.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(144, 57);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(180, 29);
            this.txtNumero.TabIndex = 3;
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoPais.Location = new System.Drawing.Point(16, 56);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(40, 29);
            this.txtCodigoPais.TabIndex = 1;
            // 
            // lblGuion1
            // 
            this.lblGuion1.AutoSize = true;
            this.lblGuion1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuion1.Location = new System.Drawing.Point(58, 57);
            this.lblGuion1.Name = "lblGuion1";
            this.lblGuion1.Size = new System.Drawing.Size(20, 25);
            this.lblGuion1.TabIndex = 3;
            this.lblGuion1.Text = "-";
            // 
            // lblGuion2
            // 
            this.lblGuion2.AutoSize = true;
            this.lblGuion2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuion2.Location = new System.Drawing.Point(121, 57);
            this.lblGuion2.Name = "lblGuion2";
            this.lblGuion2.Size = new System.Drawing.Size(20, 25);
            this.lblGuion2.TabIndex = 4;
            this.lblGuion2.Text = "-";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(16, 110);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(75, 23);
            this.btnLlamar.TabIndex = 4;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // lblCodArea
            // 
            this.lblCodArea.AutoSize = true;
            this.lblCodArea.Location = new System.Drawing.Point(10, 38);
            this.lblCodArea.Name = "lblCodArea";
            this.lblCodArea.Size = new System.Drawing.Size(54, 15);
            this.lblCodArea.TabIndex = 5;
            this.lblCodArea.Text = "Cod area";
            // 
            // lblPrefijo
            // 
            this.lblPrefijo.AutoSize = true;
            this.lblPrefijo.Location = new System.Drawing.Point(79, 38);
            this.lblPrefijo.Name = "lblPrefijo";
            this.lblPrefijo.Size = new System.Drawing.Size(41, 15);
            this.lblPrefijo.TabIndex = 6;
            this.lblPrefijo.Text = "Prefijo";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(144, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Numero";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Location = new System.Drawing.Point(294, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(30, 26);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblTelefonoDisponible
            // 
            this.lblTelefonoDisponible.AutoSize = true;
            this.lblTelefonoDisponible.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefonoDisponible.Location = new System.Drawing.Point(9, 7);
            this.lblTelefonoDisponible.Name = "lblTelefonoDisponible";
            this.lblTelefonoDisponible.Size = new System.Drawing.Size(0, 25);
            this.lblTelefonoDisponible.TabIndex = 9;
            // 
            // FrmMenuTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 169);
            this.Controls.Add(this.lblTelefonoDisponible);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPrefijo);
            this.Controls.Add(this.lblCodArea);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.lblGuion2);
            this.Controls.Add(this.lblGuion1);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtPrefijo);
            this.MinimumSize = new System.Drawing.Size(352, 208);
            this.Name = "FrmMenuTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabina telefonica";
            this.Load += new System.EventHandler(this.FrmMenuTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Label lblGuion1;
        private System.Windows.Forms.Label lblGuion2;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Label lblCodArea;
        private System.Windows.Forms.Label lblPrefijo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblTelefonoDisponible;
    }
}