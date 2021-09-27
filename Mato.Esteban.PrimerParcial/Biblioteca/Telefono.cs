using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefono : Equipo
    {
        public enum Tipo
        {
            Disco, Cable
        }

        public enum TipoLlamada
        {
            Local, LargaDistancia, Nacional
        }

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
    }
}
