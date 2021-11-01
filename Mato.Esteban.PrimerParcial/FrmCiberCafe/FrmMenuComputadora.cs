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
    public partial class FrmMenuComputadora : Form
    {
        private readonly CiberCafe ciber;
        private Jugador jugador;
        private int indice;
        public FrmMenuComputadora(CiberCafe ciber, Jugador jugador)
        {
            InitializeComponent();
            this.ciber = ciber;
            this.jugador = jugador;
        }

        private void FrmMenuComputadora_Load(object sender, EventArgs e)
        {
            bool encontro = false;
            foreach (Equipo equipo in ciber.ListaEquipos)
            {
                if(equipo is Computadora)
                {
                    if (jugador == (Computadora)equipo && ((Computadora)equipo).Disponible)
                    {
                        encontro = true;
                        int n = dtgvEquipoDisponible.Rows.Add();
                        dtgvEquipoDisponible.Rows[n].Cells[0].Value = ((Computadora)equipo).Nombre;

                        StringBuilder sb = new StringBuilder();
                        for (int i= 0; i<((Computadora)equipo).ListadoSoftwares.Count; i++)
                        {
                            sb.AppendLine($"{((Computadora)equipo).ListadoSoftwares[i].ToString()}, ");
                        }
                        dtgvEquipoDisponible.Rows[n].Cells[1].Value = sb.ToString();

                        sb.Clear();
                        for (int i = 0; i < ((Computadora)equipo).ListadoJuegos.Count; i++)
                        {
                            sb.AppendLine($"{((Computadora)equipo).ListadoJuegos[i].ToString()}, ");
                        }
                        dtgvEquipoDisponible.Rows[n].Cells[2].Value = sb.ToString();

                        sb.Clear();
                        for (int i = 0; i < ((Computadora)equipo).ListadoPerifericos.Count; i++)
                        {
                            sb.AppendLine($"{((Computadora)equipo).ListadoPerifericos[i].ToString()}, ");
                        }
                        dtgvEquipoDisponible.Rows[n].Cells[3].Value = sb.ToString();

                        dtgvEquipoDisponible.Rows[n].Cells[4].Value = ((Computadora)equipo).Procesador;
                        dtgvEquipoDisponible.Rows[n].Cells[5].Value = ((Computadora)equipo).Ram;
                        dtgvEquipoDisponible.Rows[n].Cells[6].Value = ((Computadora)equipo).PlacaVideo;
                    }
                }     
            }
            if (!encontro)
            {
                MessageBox.Show("No hay equipo disponible que cumpla lo solicitado por el cliente");
            }

            rtbInformaciónAlquiler.Text += jugador.Mostrar();
        }

        private void chkTIempoLibre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTIempoLibre.Checked)
                numericTimepoUso.Enabled = false;
            else
                numericTimepoUso.Enabled = true;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            double tiempoUso = 0;
            if (indice != -1)
            {
                if (!chkTIempoLibre.Checked)
                {
                    tiempoUso = (double)numericTimepoUso.Value;
                }
                this.ciber.AsignarEquipo(jugador, dtgvEquipoDisponible.Rows[indice].Cells[0].Value.ToString(), tiempoUso);
                MessageBox.Show($"Se asigno \n \n{((Cliente)jugador).Mostrar()} \n \n Al equipo {dtgvEquipoDisponible.Rows[indice].Cells[0].Value.ToString()}");
            }
            this.Close();
        }

        private void dtgvEquipoDisponible_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---MENU COMPUTADORA---");
            sb.AppendLine("Información cliente: Se podrá visualizar la informacion del cliente, asi como requerimientos solicitados para el equipo");
            sb.AppendLine("\nEquipos disponibles: Listará los equipos disponibles que cumplan con los requisitos del cliente");
            sb.AppendLine("\nTiempo de uso: Se podrá tildar la opción 'Tiempo Libre' o la cantidad de minutos que se desea utilizar el equipo");
            sb.AppendLine("\nAsignar: Asignara el equipo seleccionado al cliente");

            MessageBox.Show(sb.ToString());
        }
    }
}
