
namespace FrmCiberCafe
{
    partial class FrmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvEstadoEquipo = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstadoEquipo = new System.Windows.Forms.Label();
            this.lstbListaClientes = new System.Windows.Forms.ListBox();
            this.btnProximoCliente = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnNuevoAlquiler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstadoEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEstadoEquipo
            // 
            this.dtgvEstadoEquipo.AllowUserToAddRows = false;
            this.dtgvEstadoEquipo.AllowUserToResizeColumns = false;
            this.dtgvEstadoEquipo.AllowUserToResizeRows = false;
            this.dtgvEstadoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEstadoEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstadoEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Tipo,
            this.Estado,
            this.Cliente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEstadoEquipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEstadoEquipo.Location = new System.Drawing.Point(12, 27);
            this.dtgvEstadoEquipo.Name = "dtgvEstadoEquipo";
            this.dtgvEstadoEquipo.ReadOnly = true;
            this.dtgvEstadoEquipo.RowHeadersVisible = false;
            this.dtgvEstadoEquipo.RowTemplate.Height = 25;
            this.dtgvEstadoEquipo.Size = new System.Drawing.Size(555, 286);
            this.dtgvEstadoEquipo.TabIndex = 0;
            this.dtgvEstadoEquipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEstadoEquipo_CellClick);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de clientes";
            // 
            // lblEstadoEquipo
            // 
            this.lblEstadoEquipo.AutoSize = true;
            this.lblEstadoEquipo.Location = new System.Drawing.Point(12, 9);
            this.lblEstadoEquipo.Name = "lblEstadoEquipo";
            this.lblEstadoEquipo.Size = new System.Drawing.Size(103, 15);
            this.lblEstadoEquipo.TabIndex = 3;
            this.lblEstadoEquipo.Text = "Estado de equipos";
            // 
            // lstbListaClientes
            // 
            this.lstbListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbListaClientes.FormattingEnabled = true;
            this.lstbListaClientes.ItemHeight = 15;
            this.lstbListaClientes.Location = new System.Drawing.Point(12, 341);
            this.lstbListaClientes.Name = "lstbListaClientes";
            this.lstbListaClientes.Size = new System.Drawing.Size(555, 154);
            this.lstbListaClientes.TabIndex = 4;
            // 
            // btnProximoCliente
            // 
            this.btnProximoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximoCliente.Location = new System.Drawing.Point(629, 27);
            this.btnProximoCliente.Name = "btnProximoCliente";
            this.btnProximoCliente.Size = new System.Drawing.Size(102, 55);
            this.btnProximoCliente.TabIndex = 5;
            this.btnProximoCliente.Text = "Proximo Cliente";
            this.btnProximoCliente.UseVisualStyleBackColor = true;
            this.btnProximoCliente.Click += new System.EventHandler(this.btnProximoCliente_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.Location = new System.Drawing.Point(629, 99);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(102, 55);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformacion.Location = new System.Drawing.Point(629, 170);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(102, 55);
            this.btnInformacion.TabIndex = 7;
            this.btnInformacion.Text = "Info equipos";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadisticas.Location = new System.Drawing.Point(629, 241);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(102, 55);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Location = new System.Drawing.Point(782, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(33, 28);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnNuevoAlquiler
            // 
            this.btnNuevoAlquiler.Location = new System.Drawing.Point(629, 440);
            this.btnNuevoAlquiler.Name = "btnNuevoAlquiler";
            this.btnNuevoAlquiler.Size = new System.Drawing.Size(102, 55);
            this.btnNuevoAlquiler.TabIndex = 10;
            this.btnNuevoAlquiler.Text = "Nuevo Alquiler";
            this.btnNuevoAlquiler.UseVisualStyleBackColor = true;
            this.btnNuevoAlquiler.Click += new System.EventHandler(this.btnNuevoAlquiler_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 516);
            this.Controls.Add(this.btnNuevoAlquiler);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnProximoCliente);
            this.Controls.Add(this.lstbListaClientes);
            this.Controls.Add(this.lblEstadoEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvEstadoEquipo);
            this.MinimumSize = new System.Drawing.Size(836, 555);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esteban Mato";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstadoEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEstadoEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstadoEquipo;
        private System.Windows.Forms.ListBox lstbListaClientes;
        private System.Windows.Forms.Button btnProximoCliente;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Button btnNuevoAlquiler;
    }
}