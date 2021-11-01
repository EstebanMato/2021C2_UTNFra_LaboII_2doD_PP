using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Alquiler
    {
        Cliente cliente;
        Equipo equipo;
        double costo;
        TimeSpan tiempoUso;
        /// <summary>
        /// Constructor por defecto que recibe un Cliente, Equipo y el costo
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="equipo"></param>
        /// <param name="costo"></param>
        private Alquiler(Cliente cliente, Equipo equipo, double costo)
        {
            this.cliente = cliente;
            this.equipo = equipo;
            this.costo = costo;
        }

        /// <summary>
        /// Constructor que recibe un Cliente, Equipo y llama al constructor por defecto
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="equipo"></param>
        public Alquiler(Cliente cliente, Equipo equipo)
              : this(cliente, equipo,0)
        { 
        }

        public Cliente Cliente 
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }
        public Equipo Equipo
        {
            get
            {
                return this.equipo;
            }
            set
            {
                this.equipo = value;
            }
        }
       
        public double Costo 
        {
            get
            {
                return costo;
            }
            set
            {
                costo = value;
            }
        }
        public TimeSpan TiempoUso
        {
            get
            {
                return tiempoUso;
            }
            set
            {
                tiempoUso = value;
            }
        }

        /// <summary>
        /// Calcula el costo de un Alquiler
        /// </summary>
        /// <param name="alquiler"></param>
        /// <returns></returns>
        public string CalcularCosto(Jugador jugador)
        {
            if (jugador.HoraInicial == jugador.HoraFinal)
                jugador.HoraFinal = DateTime.Now;

            this.TiempoUso = jugador.TiempoDeUso();
            ((Computadora)this.Equipo).TiempoDeUso += TiempoUso;

            double tiempoUsoAux = TiempoUso.TotalSeconds;

            int cantMediaHora = 0;

            while (tiempoUsoAux > 0)
            {
                tiempoUsoAux -= 30;
                cantMediaHora++;
            }

            this.Costo = cantMediaHora * 0.50;

            return this.Mostrar();
        }


        /// <summary>
        /// Retorna el costo de un Llamador
        /// </summary>
        /// <param name="alquiler"></param>
        /// <returns></returns>
        public string CalcularCosto(Llamador llamador)
        {
            this.TiempoUso = llamador.TiempoDeUso();

            ((Telefono)this.Equipo).TiempoDeUso += TiempoUso;

            switch (llamador.TipoLlamada)
            {
                case Llamador.ETipoLlamada.LargaDistancia:
                    {
                        this.Costo = this.Costo = (this.TiempoUso.Days * 24 * 60 * 60 +
                                            TiempoUso.Hours * 60 * 60 +
                                            TiempoUso.Minutes * 60 +
                                            TiempoUso.Seconds) * 5;
                        break;
                    }
                case Llamador.ETipoLlamada.Nacional:
                    {
                        this.Costo = (this.TiempoUso.Days * 24 * 60 * 60 +
                                            TiempoUso.Hours * 60 * 60 +
                                            TiempoUso.Minutes * 60 +
                                            TiempoUso.Seconds) * 2.50;
                        break;
                    }
                default:
                    {
                        this.Costo = (this.TiempoUso.Days * 24 * 60 * 60 +
                                            TiempoUso.Hours * 60 * 60 +
                                            TiempoUso.Minutes * 60 +
                                            TiempoUso.Seconds) * 1;
                        break;
                    }
            }
            this.Costo = Math.Round(this.Costo, 2);

            return this.Mostrar();
        }
        /// <summary>
        /// Imprime los datos de un alquiler 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if(this.Cliente is Jugador)
            {
                if (((Jugador)this.Cliente).HoraInicial != DateTime.MinValue)
                    sb.AppendLine($"\nHora Inicial: {((Jugador)this.Cliente).HoraInicial}");
                if (((Jugador)this.Cliente).HoraFinal != DateTime.MinValue)
                    sb.AppendLine($"\nHora Final: {((Jugador)this.Cliente).HoraFinal}");

                sb.AppendFormat("\nTiempo de uso: {0:hh\\:mm\\:ss}",this.TiempoUso);

                if (this.Costo != 0)
                {
                    sb.AppendLine($"\nPrecio Bruto: ${this.Costo}");
                    sb.AppendLine($"\nPrecio final Neto(+IVA): ${(this.Costo+ this.Costo*0.21)}");
                }
            }
            else if (this.Cliente is Llamador)
            {
                sb.AppendFormat("Duracíon de la llamada: {0:hh\\:mm\\:ss}", this.TiempoUso);
                sb.AppendLine($"\nPrecio Bruto: ${this.Costo}");
                sb.AppendFormat($"\nPrecio final Neto(+IVA): ${(this.Costo + this.Costo * 0.21)}");

            }
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos del alquiler
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si el Cliente es igual al Cliente perteneciente al Alquiler
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="alquiler"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente cliente, Alquiler alquiler)
        {
            return (cliente == alquiler.Cliente);
        }

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si el Cliente no es igual al Cliente perteneciente al Alquiler
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="alquiler"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cliente, Alquiler alquiler)
        {
            return !(cliente == alquiler);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para un alquiler
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(Object o)
        {
            Alquiler alquiler = o as Alquiler;
            if (alquiler != null)
                return this == alquiler;
            return false;
        }

        /// <summary>
        /// Sobrecarga del método GetHashCode donde indicara si un alquiler es igual a otro a travez del Cliente, Costo y Equipo
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (this.Cliente, this.Costo, this.Equipo).GetHashCode();
        }
    }
}
