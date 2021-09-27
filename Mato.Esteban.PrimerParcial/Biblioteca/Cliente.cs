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

        public string Dni
        {
            get
            {
                return dni;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public EAccion Accion
        {
            get
            {
                return accion;
            }
        }
      
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Dni} , {Nombre}, {Apellido} , {Edad}");

            return sb.ToString();

        }
    }
}
