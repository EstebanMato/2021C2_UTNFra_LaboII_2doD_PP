using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Llamador : Cliente
    {
        string codPais;
        string prefijo;
        string numero;
        ETipoLlamada tipoLlamada;
        public enum ETipoLlamada
        {
            Local, Nacional, LargaDistancia
        }

        /// <summary>
        /// Constructor de un Llamador que recibe todos los datos por parametro
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="accion"></param>
        /// <param name="codPais"></param>
        /// <param name="prefijo"></param>
        /// <param name="numero"></param>
        public Llamador(string dni, string nombre, string apellido, int edad, EAccion accion, 
                        string codPais, string prefijo,string numero)
            : base(dni, nombre, apellido, edad, accion)
        {
            this.CodPais = codPais;
            this.Prefijo = prefijo;
            this.Numero = numero;
            this.HoraFinal = DateTime.MinValue;
        }

        /// <summary>
        /// Constructor que recibe solo el Dni, Nombre, Apellido, Edad y Accion, y llama al constructor por defecto pasando los datos como parametros
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="accion"></param>
        public Llamador(string dni, string nombre, string apellido, int edad, EAccion accion)
            :this(dni, nombre, apellido,edad,accion,"0","0","0")
        {

        }

        public string CodPais
        {
            get
            {
                return codPais;
            }
            set
            {
                codPais = value;
            }
        }
        public string Prefijo
        {
            get
            {
                return prefijo;
            }
            set
            {
                prefijo = value;
            }
        }
        public string Numero 
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public ETipoLlamada TipoLlamada
        {
            get
            {
                return tipoLlamada;
            }
            set
            {
                tipoLlamada = value;
            }
        }

        /// <summary>
        /// Valida que los numeros ingresados sean validos para realizar la llamada
        /// </summary>
        /// <param name="codPais"></param>
        /// <param name="prefijo"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool ValidarNumero(string codPais, string prefijo, string numero)
        {
            int codPaisAux;
            int prefijoAux;
            int numeroAux;
            if(int.TryParse(codPais, out codPaisAux) && int.TryParse(prefijo, out prefijoAux) && int.TryParse(numero, out numeroAux))
            {
                this.CodPais = codPais;
                this.Prefijo = prefijo;
                this.Numero = numero;
                this.DeterminarTipoLlamada();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna que tipo de llamada es LargaDistancia, Nacional o Local
        /// </summary>
        public void DeterminarTipoLlamada()
        {
            if (CodPais != "54")
                TipoLlamada = ETipoLlamada.LargaDistancia;
            else if (Prefijo != "11" && Prefijo != "011")
                TipoLlamada = ETipoLlamada.Nacional;
            else
                TipoLlamada = ETipoLlamada.Local;
        }


        /// <summary>
        /// Retorna el tiempo de uso de un equipo
        /// </summary>
        /// <returns></returns>
        public override TimeSpan TiempoDeUso()
        {
            if(base.HoraFinal==DateTime.MinValue)
                base.HoraFinal = DateTime.Now;

            return base.TiempoDeUso();
        }


        /// <summary>
        /// Retorna la informacion de un Llamador 
        /// </summary>
        /// <returns></returns>
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {CodPais} - {Prefijo} - {Numero}"); 

            return sb.ToString();
        }


        /// <summary>
        /// Sobrecarga del metodo ToString, retornara la informacion de un Llamador
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecarga del metodo Equals
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(object o)
        {
            return o is Llamador;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.Dni.GetHashCode();
        }
    }
}
