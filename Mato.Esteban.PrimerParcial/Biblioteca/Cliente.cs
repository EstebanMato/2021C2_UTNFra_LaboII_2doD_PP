using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Cliente
    {
        public enum EAccion
        {
            Llamar, Viciar
        }

        string dni;
        string nombre;
        string apellido;
        int edad;
        DateTime horaInicial;
        DateTime horaFinal;
        EAccion accion;

        /// <summary>
        /// Constructor de Cliente que recibe el Dni, Nombre, Apellido, Edad y Accion
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="accion"></param>
        public Cliente(string dni, string nombre, string apellido, int edad, EAccion accion)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Accion = accion;
        }

        public string Dni
        {
            get
            {
                return dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public EAccion Accion
        {
            get
            {
                return accion;
            }
            set
            {
                this.accion = value;
            }
        }

        public DateTime HoraInicial
        {
            get
            {
                return horaInicial;
            }
            set
            {
                this.horaInicial = value;
            }
        }
        public DateTime HoraFinal
        {
            get
            {
                return horaFinal;
            }
            set
            {
                this.horaFinal = value;
            }
        }

        /// <summary>
        /// Calcula el costo de un alquiler
        /// </summary>
        /// <param name="alquiler"></param>
        /// <returns></returns>
        //public abstract string CalcularCosto(Alquiler alquiler);

        /// <summary>
        /// Muestra los datos de un Cliente
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cliente: \n{Apellido}, {Nombre}, {Edad} años. \nDNI {Dni} \nSolicito {Accion}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve el tiempo de uso de un Cliente
        /// </summary>
        /// <returns></returns>
        public virtual TimeSpan TiempoDeUso()
        {
            TimeSpan duracion = this.HoraFinal - this.HoraInicial;

            return duracion;
        }

        /// <summary>
        /// Sobrecarga del método ToString, lista los datos de un Cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecargar del método Equals. Indica si dos clientes son iguales según Dni.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(Object o)
        {
           if(this.Dni == ((Cliente)o).Dni)
           {
               return true;
           }
           return false;
        }

        /// <summary>
        /// Sobrecargar del método GetHashCode. Indica si dos clientes son iguales según Dni
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Dni.GetHashCode();
        }
    }
}

