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
        private FrmMenuComputadora menuComputadora;


        public Computadora C1 = new Computadora();
        public Computadora C2 = new Computadora();
        public Computadora C3 = new Computadora();
        public Telefono T1 = new Telefono("Cisco", Telefono.Tipo.Cable);
        public Telefono T2 = new Telefono("Avaya", Telefono.Tipo.Disco);

        public Cliente Cli1 = new Cliente("11111111", "JuanFer", "Quinteros", 10, Cliente.EAccion.Viciar);
        public Cliente Cli2 = new Cliente("22222222", "Ignacio", "Scocco", 32, Cliente.EAccion.Viciar);
        public Cliente Cli3 = new Cliente("33333333", "Lucas", "Pratto", 27, Cliente.EAccion.Viciar);
        public Cliente Cli4 = new Cliente("44444444", "Pity", "Martinez", 10, Cliente.EAccion.Llamar);
        public Cliente Cli5 = new Cliente("55555555", "Marcelo", "Gallardo", 100, Cliente.EAccion.Llamar);


        public FrmMenu()
        {
            InitializeComponent();
            this.ciber = new CiberCafe();
            Hardcode.InicializarCompu(C1);
            Hardcode.InicializarCompu(C2);
            Hardcode.InicializarCompu(C3);
            ciber.listaDeClientes.Enqueue(Cli1);
            ciber.listaDeClientes.Enqueue(Cli2);
            ciber.listaDeClientes.Enqueue(Cli3);
            ciber.listaDeClientes.Enqueue(Cli4);
            ciber.listaDeClientes.Enqueue(Cli5);

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            menuComputadora = new FrmMenuComputadora();
            menuComputadora.ShowDialog();

            if(rbtnC1.Checked)
            {
                if(C1.clienteEnUso is null)
                    sb.Append(ciber.LlamarCliente(C1));
                else
                    sb.Append("Equipo en uso");
            }
            if (rbtnC2.Checked == true)
            {
                if (C2.clienteEnUso is null)
                    sb.Append(ciber.LlamarCliente(C2));
                else
                    sb.Append("Equipo en uso");
            }
            if (rbtnC3.Checked == true)
            {
                if (C3.clienteEnUso is null)
                    sb.Append(ciber.LlamarCliente(C3));
                else
                    sb.Append("Equipo en uso");
            }
            if (rbtnT1.Checked == true)
            {
                if (T1.clienteEnUso is null)
                    sb.Append(ciber.LlamarCliente(T1));
                else
                    sb.Append("Equipo en uso");
            }
            if (rbtnT2.Checked == true)
            {
                if (T2.clienteEnUso is null)
                    sb.Append(ciber.LlamarCliente(T2));
                else
                    sb.Append("Equipo en uso");
            }
            MessageBox.Show(sb.ToString());
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            foreach (Cliente clie in this.ciber.listaDeClientes)
            {
                lstClientes.Items.Add(clie.Mostrar());
            }

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (rbtnC1.Checked == true)
            {
                if(C1.clienteEnUso is not null)
                {
                    sb.Append(ciber.Cobrar(C1));
                    sb.Append($"\n{C1.clienteEnUso.horaInicial.ToString()} ---- {C1.clienteEnUso.horaFinal.ToString()}");
                }
                else
                {
                    sb.Append("El equipo NO en uso");
                }
            }
            if (rbtnC2.Checked == true)
            {
                if (C2.clienteEnUso is not null)
                {
                    sb.Append("Aca debería facturar");
                }
                else
                {
                    sb.Append("El equipo NO en uso");
                }
            }
            if (rbtnC3.Checked == true)
            {
                
            }
            if (rbtnT1.Checked == true)
            {
               
            }
            if (rbtnT2.Checked == true)
            {
                
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
