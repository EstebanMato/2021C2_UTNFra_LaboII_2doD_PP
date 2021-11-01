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
    public partial class FrmMenuEstadisticas : Form
    {
        private readonly CiberCafe ciber;
        public FrmMenuEstadisticas(CiberCafe ciber)
        {
            InitializeComponent();
            this.ciber = ciber;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            switch(cmbListaEstadisticas.SelectedIndex)
            {
                case 0:
                    rtbEstadistica.Text = ListadoUsoComputadoras(ciber);
                    break;
                case 1:
                    rtbEstadistica.Text = ListadoUsoTelefonos(ciber);
                    break;
                case 2:
                    rtbEstadistica.Text = GananciasTotales(ciber);
                    break;
                case 3:
                    rtbEstadistica.Text = HorasTotales(ciber);
                    break;
                case 4:
                    rtbEstadistica.Text = SoftwareMasSolicitado(ciber);
                    break;
                case 5:
                    rtbEstadistica.Text = PerifericoMasSolicitado(ciber);
                    break;
                case 6:
                    rtbEstadistica.Text = JuegoMasSolicitado(ciber);
                    break;

            }
        }

        /// <summary>
        /// Retorna el listado de uso por computadoras ordenados descendentemente 
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string ListadoUsoComputadoras(CiberCafe ciber)
        {
            List<Computadora> listaComputadoras = new List<Computadora>();
            StringBuilder sb = new StringBuilder();
            Computadora computadoraAux;

            foreach(Equipo equipo in ciber.ListaEquipos)
            {
                if(equipo is Computadora)
                {
                    listaComputadoras.Add((Computadora)equipo);
                }
            }

            for (int i = 1; i < listaComputadoras.Count; i++)
            {
                for (int j = listaComputadoras.Count - 1; j >= i; j--)
                {
                    if (listaComputadoras[j - 1].TiempoDeUso < listaComputadoras[j].TiempoDeUso)
                    {
                        computadoraAux = listaComputadoras[j - 1];
                        listaComputadoras[j - 1] = listaComputadoras[j];
                        listaComputadoras[j] = computadoraAux;
                    }
                }
            }

            foreach (Computadora computadora in listaComputadoras)
            {
                sb.AppendFormat("Tiempo de uso del equipo {0} es {1:hh\\:mm\\:ss}\n", computadora.Nombre, computadora.TiempoDeUso);
            }
            return sb.ToString();
        }


        /// <summary>
        /// Retorna el listado de uso por telefonos ordenados descendentemente 
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string ListadoUsoTelefonos(CiberCafe ciber)
        {
            List<Telefono> listaTelefonos = new List<Telefono>();
            StringBuilder sb = new StringBuilder();
            Telefono telefonoAux;

            foreach (Equipo equipo in ciber.ListaEquipos)
            {
                if (equipo is Telefono)
                {
                    listaTelefonos.Add((Telefono)equipo);
                }
            }

            for (int i = 1; i < listaTelefonos.Count; i++)
            {
                for (int j = listaTelefonos.Count - 1; j >= i; j--)
                {
                    if (listaTelefonos[j - 1].TiempoDeUso < listaTelefonos[j].TiempoDeUso)
                    {
                        telefonoAux = listaTelefonos[j - 1];
                        listaTelefonos[j - 1] = listaTelefonos[j];
                        listaTelefonos[j] = telefonoAux;
                    }
                }
            }

            foreach (Telefono telefono in listaTelefonos)
            {
                sb.AppendFormat("Tiempo de uso de la cabina {0} es {1:hh\\:mm\\:ss}\n", telefono.Nombre, telefono.TiempoDeUso);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Retorna la ganancias totales diferencias por Computadora y Telefonos
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string GananciasTotales(CiberCafe ciber)
        {
            StringBuilder sb = new StringBuilder();
            double totalTelefono=0;
            double totalComputadora=0;

            foreach(Alquiler alquiler in ciber.ListaAlquileres)
            {
                if(alquiler.Equipo is Computadora)
                {
                    totalComputadora += alquiler.Costo;
                }
                else
                {
                    totalTelefono += alquiler.Costo;

                }
            }

            sb.AppendLine($"--GANANCIAS TOTALES--\nServicio computadora: ${totalComputadora}\nServicio telefonico: ${totalTelefono}");
            return sb.ToString();
        }

        /// <summary>
        /// Retorna el tiempo total de uso de los Telefonos diferenciadas por region Local, Nacional y LargaDistancia
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string HorasTotales(CiberCafe ciber)
        {
            StringBuilder sb = new StringBuilder();
            TimeSpan horasLocal = TimeSpan.Zero;
            TimeSpan horasLargaDistancia= TimeSpan.Zero;
            TimeSpan horasNacional= TimeSpan.Zero;
            double totalLocal = 0;
            double totalNacional = 0;
            double totalLargaDistancia = 0;

            foreach (Alquiler alquiler in ciber.ListaAlquileres)
            {
                if(alquiler.Cliente is Llamador)
                {
                    switch(((Llamador)alquiler.Cliente).TipoLlamada)
                    {
                        case Llamador.ETipoLlamada.Local:
                            totalLocal += alquiler.Costo;
                            horasLocal += alquiler.TiempoUso;
                            break;
                        case Llamador.ETipoLlamada.Nacional:
                            totalNacional += alquiler.Costo;
                            horasNacional += alquiler.TiempoUso;
                            break;
                        case Llamador.ETipoLlamada.LargaDistancia:
                            totalLargaDistancia += alquiler.Costo;
                            horasLargaDistancia += alquiler.TiempoUso;
                            break;
                    }
                }
            }

            sb.AppendFormat("Tiempo total de uso por llamada locales {0:hh\\:mm\\:ss} y la recaudacion es de {1}\n", horasLocal, totalLocal);
            sb.AppendFormat("Tiempo total de uso llamada nacionales {0:hh\\:mm\\:ss} y la recaudacion es de {1}\n", horasNacional, totalNacional);
            sb.AppendFormat("Tiempo total de uso llamada a larga distancia {0:hh\\:mm\\:ss} y la recaudacion es de {1}\n", horasLargaDistancia, totalLargaDistancia);

            return sb.ToString();
        }

        /// <summary>
        /// Retorna el o los Softwares más solicitados
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string SoftwareMasSolicitado(CiberCafe ciber)
        {
            int[] contador = new int[Enum.GetNames(typeof(Computadora.ESoftware)).Length];

            int max = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < contador.Length; i++)
            {
                foreach (Alquiler alquiler in ciber.ListaAlquileres)
                {
                    if (alquiler.Cliente is Jugador)
                    {
                        foreach (Computadora.ESoftware software in ((Jugador)alquiler.Cliente).ListadoSoftwares)
                        {
                            if (software.ToString() == Enum.GetName(typeof(Computadora.ESoftware), i))
                            {
                                contador[i]++;
                            }
                        }
                    }
                }
                if (contador[i] > max)
                {
                    max = contador[i];
                }
            }

            sb.AppendLine("El software más solicitado fue:");
            for (int i = 0; i < contador.Length; i++)
            {
                if (contador[i] == max && contador[i] != 0)
                {
                    sb.AppendLine(Enum.GetName(typeof(Computadora.ESoftware), i));
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Retorna el o los Juegos más solicitados
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string JuegoMasSolicitado(CiberCafe ciber)
        {
            int[] contador = new int[Enum.GetNames(typeof(Computadora.EJuegos)).Length];

            int max = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < contador.Length; i++)
            {
                foreach (Alquiler alquiler in ciber.ListaAlquileres)
                {
                    if(alquiler.Cliente is Jugador)
                    {
                        foreach (Computadora.EJuegos juego in ((Jugador)alquiler.Cliente).ListadoJuegos)
                        {
                            if(juego.ToString() == Enum.GetName(typeof(Computadora.EJuegos), i))
                            {
                                contador[i]++;
                            }
                        }
                    }
                }
                if(contador[i]>max)
                {
                    max = contador[i];
                }
            }

            sb.AppendLine("El juego más solicitado fue:");
            for (int i = 0; i < contador.Length; i++)
            {
                if(contador[i]==max && contador[i] != 0)
                {
                    sb.AppendLine(Enum.GetName(typeof(Computadora.EJuegos), i));
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Retorna el o los Perifericos más solicitados
        /// </summary>
        /// <param name="ciber"></param>
        /// <returns></returns>
        private static string PerifericoMasSolicitado(CiberCafe ciber)
        {
            int[] contador = new int[Enum.GetNames(typeof(Computadora.EPerifericos)).Length];

            int max = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < contador.Length; i++)
            {
                foreach (Alquiler alquiler in ciber.ListaAlquileres)
                {
                    if (alquiler.Cliente is Jugador)
                    {
                        foreach (Computadora.EPerifericos periferico in ((Jugador)alquiler.Cliente).ListadoPerifericos)
                        {
                            if (periferico.ToString() == Enum.GetName(typeof(Computadora.EPerifericos), i))
                            {
                                contador[i]++;
                            }
                        }
                    }
                }
                if (contador[i] > max)
                {
                    max = contador[i];
                }
            }

            sb.AppendLine("El periferico más solicitado fue:");
            for (int i = 0; i < contador.Length; i++)
            {
                if (contador[i] == max && contador[i] != 0)
                {
                    sb.AppendLine(Enum.GetName(typeof(Computadora.EPerifericos), i));
                }
            }
            return sb.ToString();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---MENU ESTADÍSTICAS---");
            sb.AppendLine("Se podrán ver las estadísticas históricas del ciber, según el listado de datos disponibles");
            sb.AppendLine("\nVer: Listara la información de la estadística seleccionada del listado superior");

            MessageBox.Show(sb.ToString());
        }
    }
}
