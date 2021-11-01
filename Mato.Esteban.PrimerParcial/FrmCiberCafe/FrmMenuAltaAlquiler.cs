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
    public partial class FrmMenuAltaAlquiler : Form
    {
        private readonly CiberCafe ciber;
        public FrmMenuAltaAlquiler(CiberCafe ciber)
        {
            InitializeComponent();
            this.ciber = ciber;
        }

        private void FrmMenuAltaAlquiler_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtnLlamar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLlamar.Enabled)
                grpbJugador.Enabled = false;
        }

        private void rbtnViciar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnViciar.Enabled)
                grpbJugador.Enabled = true;
        }

        /// <summary>
        /// Retorna los Softwares seleccionados por el usuario
        /// </summary>
        /// <returns></returns>
        private List<Computadora.ESoftware> CargarSoftwares()
        {
            List<Computadora.ESoftware> listaSoftwares = new List<Computadora.ESoftware>();

            foreach (string item in chklistSoftwares.CheckedItems)
            {
                foreach (Computadora.ESoftware software in Enum.GetValues(typeof(Computadora.ESoftware)))
                {
                    if (item.ToString() == software.ToString())
                    {
                        listaSoftwares.Add(software);
                    }
                }
            }

            return listaSoftwares;
        }

        /// <summary>
        /// Retorna los perifericos seleccionados por el usuario
        /// </summary>
        /// <returns></returns>
        private List<Computadora.EPerifericos> CargarPerifericos()
        {
            List<Computadora.EPerifericos> listaPerifericos = new List<Computadora.EPerifericos>();

            foreach (string item in chklistPerifericos.CheckedItems)
            {
                foreach (Computadora.EPerifericos periferico in Enum.GetValues(typeof(Computadora.EPerifericos)))
                {
                    if (item.ToString() == periferico.ToString())
                    {
                        listaPerifericos.Add(periferico);
                    }
                }
            }
            return listaPerifericos;
        }

        /// <summary>
        /// Retorna los Juegos seleccionados por el usuario
        /// </summary>
        /// <returns></returns>
        private List<Computadora.EJuegos> CargarJuegos()
        {
            List<Computadora.EJuegos> listaJuegos = new List<Computadora.EJuegos>();

            foreach (string item in chklistJuegos.CheckedItems)
            {
                foreach (Computadora.EJuegos juego in Enum.GetValues(typeof(Computadora.EJuegos)))
                {
                    if (item.ToString() == juego.ToString())
                    {
                        listaJuegos.Add(juego);
                    }
                }
            }
            return listaJuegos;
        }

        /// <summary>
        /// Retorna el Procesador seleccionado por el usuario
        /// </summary>
        /// <returns></returns>
        private Computadora.EProcesador CargarProcesador()
        {
            Computadora.EProcesador procesadorAux = Computadora.EProcesador.Intel;

            foreach (Computadora.EProcesador procesador in Enum.GetValues(typeof(Computadora.EProcesador)))
            {
                if (cmbProcesador.SelectedItem is not null && cmbProcesador.SelectedItem.ToString() == procesador.ToString())
                {
                    procesadorAux = procesador;
                    break;
                }
            }
            return procesadorAux;
        }

        /// <summary>
        /// Retorna la Memoria Ram seleccionadoa por el usuario
        /// </summary>
        /// <returns></returns>
        private Computadora.ERAM CargarRam()
        {
            Computadora.ERAM ramAux = Computadora.ERAM.Uno;

            foreach (Computadora.ERAM ram in Enum.GetValues(typeof(Computadora.ERAM)))
            {
                if (cmbRam.SelectedItem is not null && cmbRam.SelectedItem.ToString() == ram.ToString())
                {
                    ramAux = ram;
                    break;
                }
            }
            return ramAux;
        }

        /// <summary>
        /// Retorna la Placa de Video seleccionado por el usuario
        /// </summary>
        /// <returns></returns>
        private Computadora.EPlacaVideo CargarPlacaVideo()
        {
            Computadora.EPlacaVideo placaAux = Computadora.EPlacaVideo.Mala;

            foreach (Computadora.EPlacaVideo placa in Enum.GetValues(typeof(Computadora.EPlacaVideo)))
            {
                if (cmbPlacaVideo.SelectedItem is not null && cmbPlacaVideo.SelectedItem.ToString() == placa.ToString())
                {
                    placaAux = placa;
                    break;
                }
            }
            return placaAux;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            int edadAux = 0;
            Cliente Cli;
            if (rbtnLlamar.Checked && txtDni.Text != string.Empty && txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && int.TryParse(txtEdad.Text, out edadAux))
            {
                Cli = new Llamador(txtDni.Text, txtNombre.Text, txtApellido.Text, edadAux, Cliente.EAccion.Llamar);

            }
            else if(rbtnViciar.Checked && txtDni.Text != string.Empty && txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && int.TryParse(txtEdad.Text, out edadAux))
            {
                Cli = new Jugador(txtDni.Text, txtNombre.Text, txtApellido.Text, edadAux, Cliente.EAccion.Viciar, CargarSoftwares(), CargarPerifericos(), CargarJuegos(),
                                            CargarProcesador(), CargarRam(), CargarPlacaVideo());
            }
            else
            {
                MessageBox.Show("Error en el ingreso de los datos");
                return;
            }
            
            ciber.ListaClientes.Enqueue(Cli);
            MessageBox.Show($"Se dio de alta \n{Cli.Mostrar()}");
            this.Close();

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("--Menu Alta Alquiler--" +
                            "\n\n Se podra ingresar un nuevo alquiler tanto para llamar como para jugar" +
                            "\n\n Se deberá ingresar Nombre, Apellido, Dni, Edad y el tipo de acción a realizar" +
                            "\n\n En caso de Viciar, se deberá elegir que componentes son los requeridos por el cliente " +
                            "\n(De no especificar se asignaran los mínimos para poder utilizar un equipo: Procesador Intel, Ram Uno, Placa de Video Mala).");
        }
    }
}
