using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefono : Equipo
    {
        #region ENUMERADOS
        public enum Tipo
        {
            Disco, Cable
        }

        public enum TipoLlamada
        {
            Local, LargaDistancia, Nacional
        }
        #endregion
        protected string marca;
        public Tipo tipo;

        public Telefono()
        {

        }
        public Telefono(string marca, Telefono.Tipo tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
        }

        public override double CalcularCosto()
        {
            return 0;
        }
    }
}
