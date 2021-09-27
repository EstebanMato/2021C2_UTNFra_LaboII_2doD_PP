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

        public List<ESoftware> ListadoSoftware
        {
            set
            {
                listadoSoftwares = value;
            }
        }
        public List<EPerifericos> ListadoPerifericos
        {
            set
            {
                listadoPerifericos = value;
            }
        }
        public List<EJuegos> ListadoJuegos
        {
            set
            {
                listadoJuegos = value;
            }
        }

        public Computadora.EProcesador Procesador
        {
            set
            {
                this.procesador = value;
            }
        }
        public Computadora.ERAM Ram
        {
            set
            {
                this.ram = value;
            }
        }
        public Computadora.EPlacaVideo PlacaVideo
        {
            set
            {
                this.placaVideo = value;
            }
        }
    }
}
