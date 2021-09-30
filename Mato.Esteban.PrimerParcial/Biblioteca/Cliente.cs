using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        public enum EAccion
        {
            Llamar, Viciar
        }

        public string dni;
        public string nombre;
        public string apellido;
        public int edad;
        public DateTime horaInicial;
        public DateTime horaFinal;
        public EAccion accion;
        public Equipo equipo;

        public Cliente()
        {

        }
        public Cliente(string dni, string nombre, string apellido, int edad, EAccion accion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.accion = accion;
        }

        #region GETTERS Y SETTERS
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
#endregion
        
        public double TiempoDeUso()
        {
          //  TimeSpan duracion = this.HoraFinal - this.HoraInicial;
            TimeSpan duracion = DateTime.Now.AddSeconds(29) - DateTime.Now;

            double segundosTotales = duracion.TotalSeconds;

            return segundosTotales;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Dni} , {Nombre}, {Apellido} , {Edad}");

            return sb.ToString();
        }


    }
}
