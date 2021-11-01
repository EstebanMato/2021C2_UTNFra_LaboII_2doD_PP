using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador : Cliente
    {
        List<Computadora.ESoftware> listadoSoftwares;
        List<Computadora.EPerifericos> listadoPerifericos;
        List<Computadora.EJuegos> listadoJuegos;
        Computadora.EProcesador procesador;
        Computadora.ERAM ram;
        Computadora.EPlacaVideo placaVideo;

        public List<Computadora.ESoftware> ListadoSoftwares
        {
            get
            {
                return listadoSoftwares;
            }
            set
            {
                listadoSoftwares = value;
            }
        }
        public List<Computadora.EPerifericos> ListadoPerifericos 
        {
            get
            {
                return listadoPerifericos;
            }
            set
            {
                listadoPerifericos = value;
            }
        }
        public List<Computadora.EJuegos> ListadoJuegos 
        {
            get
            {
                return listadoJuegos;
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
                return procesador; 
            }
            set
            {
                procesador = value;
            }
        }
        public Computadora.ERAM Ram 
        {
            get
            {
                return ram;
            }
            set
            {
                ram = value;
            } 
        }
        public Computadora.EPlacaVideo PlacaVideo 
        { 
            get
            {
                return placaVideo;
            }
            set
            {
                placaVideo = value;
            } 
        }

        /// <summary>
        /// Constructor de un Jugador que recibe todos los datos por parametros
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="accion"></param>
        /// <param name="listadoSoftwares"></param>
        /// <param name="listadoPerifericos"></param>
        /// <param name="listadoJuegos"></param>
        /// <param name="procesador"></param>
        /// <param name="ram"></param>
        /// <param name="placaVideo"></param>
        public Jugador(string dni, string nombre, string apellido, int edad, EAccion accion, 
                        List<Computadora.ESoftware> listadoSoftwares, List<Computadora.EPerifericos> listadoPerifericos, 
                        List<Computadora.EJuegos> listadoJuegos, Computadora.EProcesador procesador,
                        Computadora.ERAM ram, Computadora.EPlacaVideo placaVideo)
            : base(dni, nombre, apellido, edad, accion)
        {
            this.listadoSoftwares = listadoSoftwares;
            this.listadoPerifericos = listadoPerifericos;
            this.listadoJuegos = listadoJuegos;
            this.procesador = procesador;
            this.ram = ram;
            this.placaVideo = placaVideo;
            this.HoraInicial = DateTime.MinValue;
        }

        /// <summary>
        /// Muestra los datos de un Jugador
        /// </summary>
        /// <returns></returns>
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());

            sb.AppendLine("\nSoftwares solicitados: ");
            for (int i = 0; i < (this.ListadoSoftwares.Count); i++)
            {
                sb.AppendLine($"{this.ListadoSoftwares[i].ToString()}, ");
            }

            sb.AppendLine("\nJuegos solicitados: ");

            for (int i = 0; i < (this.ListadoJuegos.Count); i++)
            {
                sb.AppendLine($"{this.ListadoJuegos[i].ToString()}, ");
            }

            sb.AppendLine("\nPerifericos solicitados: ");

            for (int i = 0; i < (this.ListadoPerifericos.Count); i++)
            {
                sb.AppendLine($"{this.ListadoPerifericos[i].ToString()}, ");
            }

            sb.AppendLine($"\nMarca procesador: {this.Procesador}");
            sb.AppendLine($"Mínimo de Memoria RAM: {this.Ram}");
            sb.AppendLine($"Calidad de placa de Video: {this.PlacaVideo}");

            return sb.ToString();
        }


        /// <summary>
        /// Sobrecarga del metodo ToString que mostrara la informacion de un cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }


        /// <summary>
        /// Calcula el tiempo de uso de un Jugador
        /// </summary>
        /// <returns></returns>
        public override TimeSpan TiempoDeUso()
        {
            return base.TiempoDeUso();
        }

        /// <summary>
        /// Sobrecarga del metodo Equals
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(object o)
        {
            return o is Jugador;
        }

        /// <summary>
        /// Sobrecarga del metodo GethashCode, compara si dos Clientes son iguales segun su Dni
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.Dni.GetHashCode();
        }
    }
}
