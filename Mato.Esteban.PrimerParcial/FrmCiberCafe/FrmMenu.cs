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
        private FrmMenuTelefono menuTelefono;
        private FrmMenuEstadisticas menuEstadisticas;
        private FrmMenuAltaAlquiler menuAltaAlquiler;
        int indice;
        public FrmMenu()
        {
            InitializeComponent();
            this.ciber = new CiberCafe();
            Hardcodeo.InicializarEquipos(ciber);
            Hardcodeo.InicializarClientes(ciber);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.RecagarListaClientes();
            this.RecargarListaEquipo();
            this.Text = $"Operador: Esteban Mato, {DateTime.Now.ToString("D")}";
        }


        private void btnProximoCliente_Click(object sender, EventArgs e)
        {
            Cliente proxCliente = ciber.ProximoCliente();

            if (proxCliente is not null)
            {
                if(proxCliente.Accion is Biblioteca.Cliente.EAccion.Viciar)
                {
                    menuComputadora = new FrmMenuComputadora(ciber, (Jugador)proxCliente);
                    menuComputadora.ShowDialog();

                }
                else if(proxCliente.Accion is Biblioteca.Cliente.EAccion.Llamar)
                {
                    menuTelefono = new FrmMenuTelefono(ciber, (Llamador)proxCliente);
                    menuTelefono.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay clientes en espera");
            }
            RecagarListaClientes();
            RecargarListaEquipo();
        }

        /// <summary>
        /// Recarga la lsita de clientes en espera
        /// </summary>
        private void RecagarListaClientes()
        {
            lstbListaClientes.Items.Clear();
            foreach (Cliente cliente in ciber.ListaClientes)
            {
                lstbListaClientes.Items.Add(cliente.Mostrar());
            }
        }

        /// <summary>
        /// Recarga el listado de Estados de Equipos
        /// </summary>
        private void RecargarListaEquipo()
        {
            dtgvEstadoEquipo.Rows.Clear();
            Alquiler alquier;
            foreach (Equipo equipo in ciber.ListaEquipos)
            {
                alquier = ciber.GetAlquiler(equipo);
                int n = dtgvEstadoEquipo.Rows.Add();
                if(equipo.Disponible)
                {
                    dtgvEstadoEquipo.Rows[n].Cells[2].Value = "Libre";
                    dtgvEstadoEquipo.Rows[n].Cells[3].Value = "--";
                }
                else
                {
                    dtgvEstadoEquipo.Rows[n].Cells[2].Value = "Ocupado";
                    dtgvEstadoEquipo.Rows[n].Cells[3].Value = $"{alquier.Cliente.Nombre}, {alquier.Cliente.Apellido}";
                }
                if (equipo is Computadora)
                {
                    dtgvEstadoEquipo.Rows[n].Cells[0].Value = ((Computadora)equipo).Nombre;
                    dtgvEstadoEquipo.Rows[n].Cells[1].Value = "Computadora";

                }
                else if (equipo is Telefono)
                {
                    dtgvEstadoEquipo.Rows[n].Cells[0].Value = ((Telefono)equipo).Nombre;
                    dtgvEstadoEquipo.Rows[n].Cells[1].Value = "Telefono";
                }
            }
        }

        private void dtgvEstadoEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Equipo equipo = ciber.GetEquipo(dtgvEstadoEquipo.Rows[indice].Cells[0].Value.ToString());
            Alquiler alquiler = ciber.GetAlquiler(equipo);
            
            if (alquiler is null)
            {
                MessageBox.Show("Equipo no en uso");
            }
            else
            {
                CiberCafe.FinalizarAlquiler(alquiler);

                if(alquiler.Cliente is Jugador)
                    MessageBox.Show($"Se finalizo la sesión del equipo {equipo.Nombre} \n{alquiler.CalcularCosto((Jugador)alquiler.Cliente)}");

                if (alquiler.Cliente is Llamador)
                    MessageBox.Show($"Se finalizo la sesión del equipo {equipo.Nombre} \n{alquiler.CalcularCosto((Llamador)alquiler.Cliente)}");
                RecagarListaClientes();
                RecargarListaEquipo();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---MENU PRINCIPAL---");
            sb.AppendLine("Estado de equipos: Se podra observar los equipos disponibles, los que no y por quien se esta ocupando el equipo.");
            sb.AppendLine("\nLista de clientes: Se podra observar los clientes en espera y el tipo de alquiler solicitado");
            sb.AppendLine("\nProximo cliente: Llamara al proximo cliente de la lista");
            sb.AppendLine("\nCobrar: Finalizara la sesion y facturara el equipo seleccionado actualmente");
            sb.AppendLine("\nInfo equipos: Mostrara la información del equipo seleccionado");
            sb.AppendLine("\nEstadisticas: Menu de estadisticas historicas");

            MessageBox.Show(sb.ToString());
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Equipo equipo = ciber.GetEquipo(dtgvEstadoEquipo.Rows[indice].Cells[0].Value.ToString());
            MessageBox.Show(equipo.Mostrar());   
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            menuEstadisticas = new FrmMenuEstadisticas(ciber);
            menuEstadisticas.ShowDialog();
        }

        private void btnNuevoAlquiler_Click(object sender, EventArgs e)
        {
            menuAltaAlquiler = new FrmMenuAltaAlquiler(ciber);
            menuAltaAlquiler.ShowDialog();
            RecagarListaClientes();
        }
    }
}
