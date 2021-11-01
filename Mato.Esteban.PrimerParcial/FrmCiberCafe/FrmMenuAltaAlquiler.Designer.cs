
namespace FrmCiberCafe
{
    partial class FrmMenuAltaAlquiler
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.rbtnLlamar = new System.Windows.Forms.RadioButton();
            this.rbtnViciar = new System.Windows.Forms.RadioButton();
            this.chklistSoftwares = new System.Windows.Forms.CheckedListBox();
            this.grpbTipoAlquiler = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cmbProcesador = new System.Windows.Forms.ComboBox();
            this.cmbPlacaVideo = new System.Windows.Forms.ComboBox();
            this.cmbRam = new System.Windows.Forms.ComboBox();
            this.grpbJugador = new System.Windows.Forms.GroupBox();
            this.chklistPerifericos = new System.Windows.Forms.CheckedListBox();
            this.chklistJuegos = new System.Windows.Forms.CheckedListBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.grpbTipoAlquiler.SuspendLayout();
            this.grpbJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAlta.Location = new System.Drawing.Point(134, 380);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 13;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(12, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(12, 124);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 106);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // rbtnLlamar
            // 
            this.rbtnLlamar.AutoSize = true;
            this.rbtnLlamar.Checked = true;
            this.rbtnLlamar.Location = new System.Drawing.Point(6, 13);
            this.rbtnLlamar.Name = "rbtnLlamar";
            this.rbtnLlamar.Size = new System.Drawing.Size(61, 19);
            this.rbtnLlamar.TabIndex = 5;
            this.rbtnLlamar.TabStop = true;
            this.rbtnLlamar.Text = "Llamar";
            this.rbtnLlamar.UseVisualStyleBackColor = true;
            this.rbtnLlamar.CheckedChanged += new System.EventHandler(this.rbtnLlamar_CheckedChanged);
            // 
            // rbtnViciar
            // 
            this.rbtnViciar.AutoSize = true;
            this.rbtnViciar.Location = new System.Drawing.Point(6, 68);
            this.rbtnViciar.Name = "rbtnViciar";
            this.rbtnViciar.Size = new System.Drawing.Size(54, 19);
            this.rbtnViciar.TabIndex = 6;
            this.rbtnViciar.Text = "Viciar";
            this.rbtnViciar.UseVisualStyleBackColor = true;
            this.rbtnViciar.CheckedChanged += new System.EventHandler(this.rbtnViciar_CheckedChanged);
            // 
            // chklistSoftwares
            // 
            this.chklistSoftwares.FormattingEnabled = true;
            this.chklistSoftwares.Items.AddRange(new object[] {
            "Office",
            "Msn",
            "Ares"});
            this.chklistSoftwares.Location = new System.Drawing.Point(6, 121);
            this.chklistSoftwares.Name = "chklistSoftwares";
            this.chklistSoftwares.Size = new System.Drawing.Size(59, 58);
            this.chklistSoftwares.TabIndex = 10;
            // 
            // grpbTipoAlquiler
            // 
            this.grpbTipoAlquiler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpbTipoAlquiler.Controls.Add(this.rbtnLlamar);
            this.grpbTipoAlquiler.Controls.Add(this.rbtnViciar);
            this.grpbTipoAlquiler.Location = new System.Drawing.Point(275, 64);
            this.grpbTipoAlquiler.Name = "grpbTipoAlquiler";
            this.grpbTipoAlquiler.Size = new System.Drawing.Size(73, 98);
            this.grpbTipoAlquiler.TabIndex = 5;
            this.grpbTipoAlquiler.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Location = new System.Drawing.Point(317, 10);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(32, 25);
            this.btnAyuda.TabIndex = 14;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // cmbProcesador
            // 
            this.cmbProcesador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbProcesador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesador.FormattingEnabled = true;
            this.cmbProcesador.Items.AddRange(new object[] {
            "Intel",
            "Amd"});
            this.cmbProcesador.Location = new System.Drawing.Point(3, 18);
            this.cmbProcesador.Name = "cmbProcesador";
            this.cmbProcesador.Size = new System.Drawing.Size(121, 23);
            this.cmbProcesador.TabIndex = 7;
            // 
            // cmbPlacaVideo
            // 
            this.cmbPlacaVideo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPlacaVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlacaVideo.FormattingEnabled = true;
            this.cmbPlacaVideo.Items.AddRange(new object[] {
            "Mala",
            "Media",
            "Buena"});
            this.cmbPlacaVideo.Location = new System.Drawing.Point(3, 77);
            this.cmbPlacaVideo.Name = "cmbPlacaVideo";
            this.cmbPlacaVideo.Size = new System.Drawing.Size(121, 23);
            this.cmbPlacaVideo.TabIndex = 9;
            // 
            // cmbRam
            // 
            this.cmbRam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRam.FormattingEnabled = true;
            this.cmbRam.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Cuatro",
            "Ocho"});
            this.cmbRam.Location = new System.Drawing.Point(3, 48);
            this.cmbRam.Name = "cmbRam";
            this.cmbRam.Size = new System.Drawing.Size(121, 23);
            this.cmbRam.TabIndex = 8;
            // 
            // grpbJugador
            // 
            this.grpbJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbJugador.Controls.Add(this.chklistPerifericos);
            this.grpbJugador.Controls.Add(this.chklistJuegos);
            this.grpbJugador.Controls.Add(this.chklistSoftwares);
            this.grpbJugador.Controls.Add(this.cmbRam);
            this.grpbJugador.Controls.Add(this.cmbPlacaVideo);
            this.grpbJugador.Controls.Add(this.cmbProcesador);
            this.grpbJugador.Enabled = false;
            this.grpbJugador.Location = new System.Drawing.Point(12, 179);
            this.grpbJugador.Name = "grpbJugador";
            this.grpbJugador.Size = new System.Drawing.Size(336, 195);
            this.grpbJugador.TabIndex = 24;
            this.grpbJugador.TabStop = false;
            this.grpbJugador.Text = "Seleccione los componetes requeridos";
            // 
            // chklistPerifericos
            // 
            this.chklistPerifericos.FormattingEnabled = true;
            this.chklistPerifericos.Items.AddRange(new object[] {
            "Camara",
            "Auriculares",
            "Microfono"});
            this.chklistPerifericos.Location = new System.Drawing.Point(97, 121);
            this.chklistPerifericos.Name = "chklistPerifericos";
            this.chklistPerifericos.Size = new System.Drawing.Size(90, 58);
            this.chklistPerifericos.TabIndex = 11;
            // 
            // chklistJuegos
            // 
            this.chklistJuegos.FormattingEnabled = true;
            this.chklistJuegos.Items.AddRange(new object[] {
            "Counter Strike",
            "Diablo",
            "Muu",
            "PES",
            "FIFA",
            "Need For Speed"});
            this.chklistJuegos.Location = new System.Drawing.Point(216, 67);
            this.chklistJuegos.Name = "chklistJuegos";
            this.chklistJuegos.Size = new System.Drawing.Size(120, 112);
            this.chklistJuegos.TabIndex = 12;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(122, 20);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 28;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 38);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 4;
            // 
            // FrmMenuAltaAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 415);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.grpbTipoAlquiler);
            this.Controls.Add(this.grpbJugador);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAlta);
            this.MinimumSize = new System.Drawing.Size(376, 454);
            this.Name = "FrmMenuAltaAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu alta alquiler";
            this.Load += new System.EventHandler(this.FrmMenuAltaAlquiler_Load);
            this.grpbTipoAlquiler.ResumeLayout(false);
            this.grpbTipoAlquiler.PerformLayout();
            this.grpbJugador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.RadioButton rbtnLlamar;
        private System.Windows.Forms.RadioButton rbtnViciar;
        private System.Windows.Forms.GroupBox grpbTipoAlquiler;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.CheckedListBox chklistSoftwares;
        private System.Windows.Forms.ComboBox cmbProcesador;
        private System.Windows.Forms.ComboBox cmbPlacaVideo;
        private System.Windows.Forms.ComboBox cmbRam;
        private System.Windows.Forms.GroupBox grpbJugador;
        private System.Windows.Forms.CheckedListBox chklistPerifericos;
        private System.Windows.Forms.CheckedListBox chklistJuegos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
    }
}