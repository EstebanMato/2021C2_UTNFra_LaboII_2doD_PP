
namespace FrmCiberCafe
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnC1 = new System.Windows.Forms.RadioButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rbtnT2 = new System.Windows.Forms.RadioButton();
            this.rbtnT1 = new System.Windows.Forms.RadioButton();
            this.rbtnC3 = new System.Windows.Forms.RadioButton();
            this.rbtnC2 = new System.Windows.Forms.RadioButton();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnC1
            // 
            this.rbtnC1.AutoSize = true;
            this.rbtnC1.Location = new System.Drawing.Point(15, 33);
            this.rbtnC1.Name = "rbtnC1";
            this.rbtnC1.Size = new System.Drawing.Size(39, 19);
            this.rbtnC1.TabIndex = 0;
            this.rbtnC1.TabStop = true;
            this.rbtnC1.Text = "C1";
            this.rbtnC1.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rbtnT2);
            this.grpBox.Controls.Add(this.rbtnT1);
            this.grpBox.Controls.Add(this.rbtnC3);
            this.grpBox.Controls.Add(this.rbtnC2);
            this.grpBox.Controls.Add(this.rbtnC1);
            this.grpBox.Location = new System.Drawing.Point(12, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(145, 139);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            // 
            // rbtnT2
            // 
            this.rbtnT2.AutoSize = true;
            this.rbtnT2.Location = new System.Drawing.Point(107, 99);
            this.rbtnT2.Name = "rbtnT2";
            this.rbtnT2.Size = new System.Drawing.Size(37, 19);
            this.rbtnT2.TabIndex = 5;
            this.rbtnT2.TabStop = true;
            this.rbtnT2.Text = "T2";
            this.rbtnT2.UseVisualStyleBackColor = true;
            // 
            // rbtnT1
            // 
            this.rbtnT1.AutoSize = true;
            this.rbtnT1.Location = new System.Drawing.Point(15, 99);
            this.rbtnT1.Name = "rbtnT1";
            this.rbtnT1.Size = new System.Drawing.Size(37, 19);
            this.rbtnT1.TabIndex = 4;
            this.rbtnT1.TabStop = true;
            this.rbtnT1.Text = "T1";
            this.rbtnT1.UseVisualStyleBackColor = true;
            // 
            // rbtnC3
            // 
            this.rbtnC3.AutoSize = true;
            this.rbtnC3.Location = new System.Drawing.Point(105, 33);
            this.rbtnC3.Name = "rbtnC3";
            this.rbtnC3.Size = new System.Drawing.Size(39, 19);
            this.rbtnC3.TabIndex = 3;
            this.rbtnC3.TabStop = true;
            this.rbtnC3.Text = "C3";
            this.rbtnC3.UseVisualStyleBackColor = true;
            // 
            // rbtnC2
            // 
            this.rbtnC2.AutoSize = true;
            this.rbtnC2.Location = new System.Drawing.Point(60, 33);
            this.rbtnC2.Name = "rbtnC2";
            this.rbtnC2.Size = new System.Drawing.Size(39, 19);
            this.rbtnC2.TabIndex = 2;
            this.rbtnC2.TabStop = true;
            this.rbtnC2.Text = "C2";
            this.rbtnC2.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(12, 191);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(12, 236);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(180, 23);
            this.btnInformacion.TabIndex = 3;
            this.btnInformacion.Text = "Mostrar Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(117, 191);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(254, 191);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(75, 23);
            this.btnEstadisticas.TabIndex = 5;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(254, 12);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(268, 169);
            this.lstClientes.TabIndex = 6;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 350);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.grpBox);
            this.Name = "FrmMenu";
            this.Text = "Esteban Mato";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnC1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rbtnC3;
        private System.Windows.Forms.RadioButton rbtnC2;
        private System.Windows.Forms.RadioButton rbtnT1;
        private System.Windows.Forms.RadioButton rbtnT2;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.ListBox lstClientes;
    }
}

