using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FrmCiberCafe
{
    public partial class FrmMenuTelefono : Form
    {
        private CiberCafe ciber;
        private Llamador llamador;
        private Telefono telefono;
        public FrmMenuTelefono(CiberCafe ciber, Llamador llamador)
        {
            InitializeComponent();
            this.ciber = ciber;
            this.llamador = llamador;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if(telefono is not null)
            {
                if (llamador.ValidarNumero(txtCodigoPais.Text, txtPrefijo.Text, txtNumero.Text))
                {
                    ciber.AsignarEquipo(llamador, telefono);
                    MessageBox.Show($"Se asigno una cabina al cliente {llamador.Apellido}, {llamador.Nombre}\n{llamador.Mostrar()}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Numero incorrecto");
                }
            }
        }

        private void FrmMenuTelefono_Load(object sender, EventArgs e)
        {
            telefono = ciber.GetTelefono();
            if(telefono is null)
            {
                lblTelefonoDisponible.Text = "NO HAY CABINAS DISPONIBLES";
                txtCodigoPais.Enabled = false;
                txtNumero.Enabled = false;
                txtPrefijo.Enabled = false;
                btnLlamar.Enabled = false;
            }
            else
            {
                lblTelefonoDisponible.Text = $"Cabina {telefono.Nombre}";
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---MENU TELEFONO---");
            sb.AppendLine("Se ingresara el número indicado por el cliente, diferenciando en Código de área, Prefijo y Número");
            sb.AppendLine("\nLlamar: Se asignara la próxima cabina disponible, la cual figurara el nombre, con el número de telefono indicado al cliente");

            MessageBox.Show(sb.ToString());
        }
    }
}
