using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Computadora : Equipo
    {
        public enum ESoftware
        {
            Office, Msn, Ares
        }

        public enum EPerifericos
        {
            Camara, Auriculares, Microfono,
        }

        public enum EJuegos
        {
            CounterStrike, Diablo, Muu, PES, FIFA, NeedForSpeed,
        }

        public enum EProcesador
        {
            Intel, Amd
        }

        public enum ERAM
        {
            Uno, Dos, Cuatro, Ocho
        }

        public enum EPlacaVideo
        {
            Mala, Media, Buena
        }

        private List<ESoftware> listadoSoftwares;
        private List<EPerifericos> listadoPerifericos;
        private List<EJuegos> listadoJuegos;
        private Computadora.EProcesador procesador;
        private Computadora.ERAM ram;
        private Computadora.EPlacaVideo placaVideo;
        private bool disponible;

        /// <summary>
        /// Constructor de Computadora que recibe el Nombre, un listado de Softwares, un listado de Perifericos,
        /// un listado de Juegos, un Procesador, una Ram y una Placa de video
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="softwares"></param>
        /// <param name="perifericos"></param>
        /// <param name="juegos"></param>
        /// <param name="procesador"></param>
        /// <param name="ram"></param>
        /// <param name="video"></param>
        public Computadora(string nombre, List<ESoftware> softwares, List<EPerifericos> perifericos, List<EJuegos> juegos,
                            Computadora.EProcesador procesador, Computadora.ERAM ram, Computadora.EPlacaVideo video)
        {
            this.Nombre = nombre;
            this.ListadoSoftwares = softwares;
            this.ListadoPerifericos = perifericos;
            this.ListadoJuegos = juegos;
            this.Procesador = procesador;
            this.Ram = ram;
            this.PlacaVideo = video;
            this.Disponible = true;
        }

        public override string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public List<ESoftware> ListadoSoftwares
        {
            get
            {
                return this.listadoSoftwares;
            }
            set
            {
                listadoSoftwares = value;
            }
        }
        public List<EPerifericos> ListadoPerifericos
        {
            get
            {
                return this.listadoPerifericos;
            }
            set
            {
                listadoPerifericos = value;
            }
        }
        public List<EJuegos> ListadoJuegos
        {
            get
            {
                return this.listadoJuegos;
            }
            set
            {
                listadoJuegos = value;
            }
        }

        public Computadora.EProcesador Procesador
        {
            get
            {
                return this.procesador;
            }
            set
            {
                this.procesador = value;
            }
        }
        public Computadora.ERAM Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }
        public Computadora.EPlacaVideo PlacaVideo
        {
            get
            {
                return this.placaVideo;
            }
            set
            {
                this.placaVideo = value;
            }
        }
        public override bool Disponible
        {
            get
            {
                return this.disponible;
            }
            set
            {
                this.disponible = value;
            }
        }

        /// <summary>
        /// Sobrecargar del método == , devuelve si los componentes de la Computadora cumplen los requisitos del Cliente, obtenidos por parámetro
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador jugador, Computadora computadora)
        {
            return CompararSoftware(jugador.ListadoSoftwares, computadora) &&
                   CompararPerifericos(jugador.ListadoPerifericos, computadora) &&
                   CompararJuegos(jugador.ListadoJuegos, computadora) &&
                   CompararProcesador(jugador.Procesador, computadora) &&
                   CompararRam(jugador.Ram, computadora)&&
                   CompararPlacaVideo(jugador.PlacaVideo, computadora);
        }

        /// <summary>
        /// Sobrecargar del método != , devuelve si los componentes de la Computadora no cumplen los requisitos del Cliente, obtenidos por parámetro
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool operator !=(Jugador jugador, Computadora computadora)
        {
            return !(jugador == computadora);
        }

        /// <summary>
        /// Sobrecarga del método Equals. Indica si dos computadoras son iguales según nombre.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(Object o)
        {
            if (this.Nombre == ((Computadora)o).Nombre)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del método GetHashCode. Indica si dos computadoras son iguales según nombre.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }

        /// <summary>
        /// Compara si una Computadora contiene los softwares que estan incluidos en la lista, pasada por parametro
        /// </summary>
        /// <param name="listSofts"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool CompararSoftware(List<Computadora.ESoftware> listSofts, Computadora computadora)
        {
            bool encontro = false;
            if (listSofts.Count != 0)
            {
                foreach (Computadora.ESoftware softAlq in listSofts)
                {
                    encontro = false;
                    foreach (Computadora.ESoftware softCompu in computadora.ListadoSoftwares)
                    {
                        encontro = false;
                        if (softAlq == softCompu)
                        {
                            encontro = true;
                            break;
                        }
                    }
                    if (!encontro)
                        return encontro;
                }
            }
            else
            {
                encontro=true;
            }
            return encontro;
        }

        /// <summary>
        /// Compara si una Computadora contiene los perifericos que estan incluidos en la lista, pasada por parametro
        /// </summary>
        /// <param name="listPeris"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool CompararPerifericos(List<Computadora.EPerifericos> listPeris, Computadora computadora)
        {
            bool encontro = false;
            if(listPeris.Count != 0)
            {
                foreach (Computadora.EPerifericos periAlq in listPeris)
                {
                    encontro = false;
                    foreach (Computadora.EPerifericos periCompu in computadora.ListadoPerifericos)
                    {
                        encontro = false;
                        if (periAlq == periCompu)
                        {
                            encontro = true;
                            break;
                        }
                    }
                    if (!encontro)
                        return encontro;
                }
            }
            else
            {
                encontro = true;
            } 
            return encontro;
        }

        /// <summary>
        /// Compara si una Computadora contiene los juegos que estan incluidos en la lista, pasada por parametro
        /// </summary>
        /// <param name="listJuegos"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool CompararJuegos(List<Computadora.EJuegos> listJuegos, Computadora computadora)
        {
            bool encontro = false;
            if(listJuegos.Count != 0)
            {
                foreach (Computadora.EJuegos juegoAlq in listJuegos)
                {
                    encontro = false;
                    foreach (Computadora.EJuegos juegoCompu in computadora.ListadoJuegos)
                    {
                        encontro = false;
                        if (juegoAlq == juegoCompu)
                        {
                            encontro = true;
                            break;
                        }
                    }
                    if (!encontro)
                        return encontro;
                }
            }
            else
            {
                encontro = true;
            }
            
            return encontro;
        }

        /// <summary>
        /// Compara si el tipo de procesador es igual al contenido por la computadora
        /// </summary>
        /// <param name="procesador"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool CompararProcesador(Computadora.EProcesador procesador, Computadora computadora)
        {
            return procesador == computadora.Procesador;
        }

        /// <summary>
        /// Compara si, la computadora, contiene una memoria Ram igual o mejor que la pasada por parametro
        /// </summary>
        /// <param name="ram"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool CompararRam(Computadora.ERAM ram, Computadora computadora)
        {
            if (ram is ERAM.Uno)
                return true;
            else if (ram is ERAM.Dos && (computadora.Ram is ERAM.Dos || computadora.Ram is ERAM.Cuatro || computadora.Ram is ERAM.Ocho))
                return true;
            else if (ram is ERAM.Cuatro && (computadora.Ram is ERAM.Cuatro || computadora.Ram is ERAM.Ocho))
                return true;
            else if (ram is ERAM.Ocho && computadora.Ram is ERAM.Ocho)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Compara si, la computadora, contiene una placa de video igual o mejor que la pasada por parametro 
        /// </summary>
        /// <param name="placaVideo"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool CompararPlacaVideo(Computadora.EPlacaVideo placaVideo, Computadora computadora)
        {
            if (placaVideo is EPlacaVideo.Mala)
                return true;
            else if (placaVideo is EPlacaVideo.Media && (computadora.PlacaVideo is EPlacaVideo.Media || computadora.PlacaVideo is EPlacaVideo.Buena))
                return true;
            else if (placaVideo is EPlacaVideo.Buena && computadora.PlacaVideo is EPlacaVideo.Buena)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Lista la información de una computadora
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Computadora {Nombre}");
            sb.AppendLine("\nSoftwares instalados: ");
            for (int i = 0; i < (this.ListadoSoftwares.Count); i++)
            {
                sb.AppendLine($"{this.ListadoSoftwares[i].ToString()}, ");
            }

            sb.AppendLine("\nJuegos instalados: ");

            for (int i = 0; i < (this.ListadoJuegos.Count); i++)
            {
                sb.AppendLine($"{this.ListadoJuegos[i].ToString()}, ");
            }

            sb.AppendLine("\nPerifericos disponibles: ");

            for (int i = 0; i < (this.ListadoPerifericos.Count); i++)
            {
                sb.AppendLine($"{this.ListadoPerifericos[i].ToString()}, ");
            }

            sb.AppendLine($"\nMarca procesador: {this.Procesador}");
            sb.AppendLine($"Memoria RAM: {this.Ram}");
            sb.AppendLine($"Calidad de placa de Video: {this.PlacaVideo}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador ToString que listara la informacion de una computadora
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
