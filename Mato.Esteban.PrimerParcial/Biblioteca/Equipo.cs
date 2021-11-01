using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;

        public abstract string Nombre { get; set; }
        public abstract bool Disponible { get; set; }
        public TimeSpan tiempoDeUso;
        public abstract string Mostrar();

        public TimeSpan TiempoDeUso
        {
            get
            {
                return tiempoDeUso;
            }
            set
            {
                tiempoDeUso = value;
            }
        }

        /// <summary>
        /// Cambia el estado de un equipo. Disponible o No Disponible
        /// </summary>
        public void CambiarEstado()
        {
            if (this.Disponible)
                this.Disponible = false;
            else
                this.Disponible = true;
        }

        /// <summary>
        /// Sobrecargar del metodo ToString, mostrara la informacion de un equipo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
