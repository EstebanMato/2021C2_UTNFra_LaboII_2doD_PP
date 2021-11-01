using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefono : Equipo
    {
        public enum ETipo
        {
            Disco, Cable
        }

        private string marca;
        private ETipo tipo;
        private bool disponible;

        public override string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        protected string Marca 
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public ETipo Tipo 
        { 
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            } 
        }
        public override bool Disponible
        {
            get
            {
                return disponible;
            }

            set
            {
                disponible = value;
            }
        }

        /// <summary>
        /// Constructor de un Telefono que recibe el Nombre, Marca y el Tipo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        public Telefono(string nombre, string marca, Telefono.ETipo tipo)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.Tipo = tipo;
            this.Disponible = true;
        }

        /// <summary>
        /// Retornara los datos de un telefono
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            return $"Telefono {Nombre}, es tipo {Tipo} y marca {Marca}";
        }


        /// <summary>
        /// Sobrecarga del metodo ToString que retornada los datos de un Telefono
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
