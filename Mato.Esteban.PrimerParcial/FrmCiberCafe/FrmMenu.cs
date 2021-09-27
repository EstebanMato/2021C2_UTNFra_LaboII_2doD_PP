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
    public partial class FrmMenu : Form
    {
        private CiberCafe ciber;
        public Computadora C1 = new Computadora();
        public Computadora C2 = new Computadora();
        public Computadora C3 = new Computadora();
        public Telefono T1 = new Telefono("Cisco", Telefono.Tipo.Cable);
        public Telefono T2 = new Telefono("Avaya", Telefono.Tipo.Disco);
        public Cliente Cli1 = new Cliente("37995842", "Esteban", "Mato", 27, Cliente.EAccion.Viciar);
        public Cliente Cli2 = new Cliente("38177081", "Veronica", "Bever", 27, Cliente.EAccion.Llamar);


        public FrmMenu()
        {
            InitializeComponent();
            this.ciber = new CiberCafe();
            Hardcode.InicializarCompu(C1);
            Hardcode.InicializarCompu(C2);
            Hardcode.InicializarCompu(C3);
            ciber.listaDeClientes.Enqueue(Cli1);
            ciber.listaDeClientes.Enqueue(Cli2);

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if(rbtnC1.Checked == true)
            {
                sb.Append(ciber.LlamarCliente(C1));
            }
            if (rbtnC2.Checked == true)
            {
                sb.Append(ciber.LlamarCliente(C2));
            }
            if (rbtnC3.Checked == true)
            {
                sb.Append(ciber.LlamarCliente(C3));
            }
            if (rbtnT1.Checked == true)
            {
                sb.Append(ciber.LlamarCliente(T1));
            }
            if (rbtnT2.Checked == true)
            {
                sb.Append(ciber.LlamarCliente(T2));
            }

            MessageBox.Show(sb.ToString());
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lstClientes.Items.Add(Cli1.Mostrar());
            lstClientes.Items.Add(Cli2.Mostrar());

        }
    }
}
