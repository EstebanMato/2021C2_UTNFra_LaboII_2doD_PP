using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Computadora : Equipo
    {
        #region ENUMERADOS
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
        #endregion

        protected List<ESoftware> listadoSoftwares;
        protected List<EPerifericos> listadoPerifericos;
        protected List<EJuegos> listadoJuegos;
        protected Computadora.EProcesador procesador;
        protected Computadora.ERAM ram;
        protected Computadora.EPlacaVideo placaVideo;

        public Computadora()
        {

        }
        public Computadora(List<ESoftware> softwares, List<EPerifericos> perifericos, List<EJuegos> juegos, 
                            Computadora.EProcesador procesador, Computadora.ERAM ram, Computadora.EPlacaVideo video)
        {
            this.listadoSoftwares = softwares;
            this.listadoPerifericos = perifericos;
            this.listadoJuegos = juegos;
            this.procesador = procesador;
            this.ram = ram;
            this.placaVideo = video;
        }

        #region GETTERS AND SETTERS
        public List<ESoftware> ListadoSoftware
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
#endregion

        /// <summary>
        /// Retorno el costo de uso una computadora
        /// </summary>
        /// <param name="cliente">Cliente que utilizo dicha computadora</param>
        /// <returns></returns>
        public override double CalcularCosto()
        {
            this.clienteEnUso.HoraFinal = DateTime.Now;
            double tiempoUso = (double)(this.clienteEnUso.TiempoDeUso());
            int cantMediaHora = 0;

            while (tiempoUso > 0)
            {
                tiempoUso -= 30;
                cantMediaHora++;
            }

            return cantMediaHora*0.50;
        }
    }
}
