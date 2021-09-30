using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected float costo;
        public Cliente clienteEnUso;

        public abstract double CalcularCosto();

    }
}
