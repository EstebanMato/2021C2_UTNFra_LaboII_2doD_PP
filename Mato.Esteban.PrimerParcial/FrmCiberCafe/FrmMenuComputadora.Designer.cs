
namespace FrmCiberCafe
{
    partial class FrmMenuComputadora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvEquipoDisponible = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Softwares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juegos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perifericos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procesador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbInformaciónAlquiler = new System.Windows.Forms.RichTextBox();
            this.numericTimepoUso = new System.Windows.Forms.NumericUpDown();
            this.chkTIempoLibre = new System.Windows.Forms.CheckBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblEquipoDisponible = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEquipoDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimepoUso)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEquipoDisponible
            // 
            this.dtgvEquipoDisponible.AllowUserToAddRows = false;
            this.dtgvEquipoDisponible.AllowUserToResizeColumns = false;
            this.dtgvEquipoDisponible.AllowUserToResizeRows = false;
            this.dtgvEquipoDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEquipoDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvEquipoDisponible.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvEquipoDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEquipoDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Softwares,
            this.Juegos,
            this.Perifericos,
            this.Procesador,
            this.RAM,
            this.PlacaVideo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEquipoDisponible.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEquipoDisponible.Location = new System.Drawing.Point(244, 45);
            this.dtgvEquipoDisponible.Name = "dtgvEquipoDisponible";
            this.dtgvEquipoDisponible.ReadOnly = true;
            this.dtgvEquipoDisponible.RowHeadersVisible = false;
            this.dtgvEquipoDisponible.RowTemplate.Height = 25;
            this.dtgvEquipoDisponible.Size = new System.Drawing.Size(453, 238);
            this.dtgvEquipoDisponible.TabIndex = 1;
            this.dtgvEquipoDisponible.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEquipoDisponible_CellClick);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 94;
            // 
            // Softwares
            // 
            this.Softwares.HeaderText = "Softwares";
            this.Softwares.Name = "Softwares";
            this.Softwares.ReadOnly = true;
            this.Softwares.Width = 83;
            // 
            // Juegos
            // 
            this.Juegos.HeaderText = "Juegos";
            this.Juegos.Name = "Juegos";
            this.Juegos.ReadOnly = true;
            this.Juegos.Width = 68;
            // 
            // Perifericos
            // 
            this.Perifericos.HeaderText = "Perifericos";
            this.Perifericos.Name = "Perifericos";
            this.Perifericos.ReadOnly = true;
            this.Perifericos.Width = 87;
            // 
            // Procesador
            // 
            this.Procesador.HeaderText = "Procesador";
            this.Procesador.Name = "Procesador";
            this.Procesador.ReadOnly = true;
            this.Procesador.Width = 91;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 58;
            // 
            // PlacaVideo
            // 
            this.PlacaVideo.HeaderText = "Placa de Video";
            this.PlacaVideo.Name = "PlacaVideo";
            this.PlacaVideo.ReadOnly = true;
            this.PlacaVideo.Width = 109;
            // 
            // rtbInformaciónAlquiler
            // 
            this.rtbInformaciónAlquiler.Location = new System.Drawing.Point(12, 45);
            this.rtbInformaciónAlquiler.Name = "rtbInformaciónAlquiler";
            this.rtbInformaciónAlquiler.Size = new System.Drawing.Size(226, 238);
            this.rtbInformaciónAlquiler.TabIndex = 2;
            this.rtbInformaciónAlquiler.Text = "";
            // 
            // numericTimepoUso
            // 
            this.numericTimepoUso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericTimepoUso.Enabled = false;
            this.numericTimepoUso.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericTimepoUso.Location = new System.Drawing.Point(369, 289);
            this.numericTimepoUso.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericTimepoUso.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericTimepoUso.Name = "numericTimepoUso";
            this.numericTimepoUso.Size = new System.Drawing.Size(47, 23);
            this.numericTimepoUso.TabIndex = 4;
            this.numericTimepoUso.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // chkTIempoLibre
            // 
            this.chkTIempoLibre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTIempoLibre.AutoSize = true;
            this.chkTIempoLibre.Checked = true;
            this.chkTIempoLibre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTIempoLibre.Location = new System.Drawing.Point(264, 290);
            this.chkTIempoLibre.Name = "chkTIempoLibre";
            this.chkTIempoLibre.Size = new System.Drawing.Size(92, 19);
            this.chkTIempoLibre.TabIndex = 5;
            this.chkTIempoLibre.Text = "Tiempo libre";
            this.chkTIempoLibre.UseVisualStyleBackColor = true;
            this.chkTIempoLibre.CheckedChanged += new System.EventHandler(this.chkTIempoLibre_CheckedChanged);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Location = new System.Drawing.Point(664, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(36, 27);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblEquipoDisponible
            // 
            this.lblEquipoDisponible.AutoSize = true;
            this.lblEquipoDisponible.Location = new System.Drawing.Point(244, 24);
            this.lblEquipoDisponible.Name = "lblEquipoDisponible";
            this.lblEquipoDisponible.Size = new System.Drawing.Size(112, 15);
            this.lblEquipoDisponible.TabIndex = 7;
            this.lblEquipoDisponible.Text = "Equipos disponibles";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsignar.Location = new System.Drawing.Point(543, 290);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(71, 40);
            this.btnAsignar.TabIndex = 8;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblInfoCliente
            // 
            this.lblInfoCliente.AutoSize = true;
            this.lblInfoCliente.Location = new System.Drawing.Point(12, 24);
            this.lblInfoCliente.Name = "lblInfoCliente";
            this.lblInfoCliente.Size = new System.Drawing.Size(110, 15);
            this.lblInfoCliente.TabIndex = 9;
            this.lblInfoCliente.Text = "Información cliente";
            // 
            // FrmMenuComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 342);
            this.Controls.Add(this.lblInfoCliente);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblEquipoDisponible);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.chkTIempoLibre);
            this.Controls.Add(this.numericTimepoUso);
            this.Controls.Add(this.rtbInformaciónAlquiler);
            this.Controls.Add(this.dtgvEquipoDisponible);
            this.MinimumSize = new System.Drawing.Size(728, 381);
            this.Name = "FrmMenuComputadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu computadora";
            this.Load += new System.EventHandler(this.FrmMenuComputadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEquipoDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimepoUso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEquipoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Softwares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perifericos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procesador;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVideo;
        private System.Windows.Forms.RichTextBox rtbInformaciónAlquiler;
        private System.Windows.Forms.NumericUpDown numericTimepoUso;
        private System.Windows.Forms.CheckBox chkTIempoLibre;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblEquipoDisponible;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblInfoCliente;
    }
}