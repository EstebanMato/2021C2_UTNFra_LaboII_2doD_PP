using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class CiberCafe
    {
        private Queue<Cliente> listaClientes;
        private List<Equipo> listaEquipos;
        private List<Alquiler> listaAlquileres;

        public Queue<Cliente> ListaClientes
        {
            get
            {
                return listaClientes;
            }
            set
            {
                listaClientes = value;
            }
        }
        
        public List<Equipo> ListaEquipos
        {
            get
            {
                return listaEquipos;
            }
            set
            {
                listaEquipos = value;
            }
        }
        public List<Alquiler> ListaAlquileres
        {
            get
            {
                return listaAlquileres;
            }
            set
            {
                listaAlquileres = value;
            }
        }

        /// <summary>
        /// Constructor por defecto de CiberCafe
        /// </summary>
        public CiberCafe()
        {
            this.ListaClientes = new Queue<Cliente>();
            this.ListaEquipos = new List<Equipo>();
            this.ListaAlquileres = new List<Alquiler>();

        }

        /// <summary>
        /// Devuelve el próximo cliente de la lista
        /// </summary>
        /// <returns></returns>
        public Cliente ProximoCliente()
        {
            if (this.ListaClientes.Count > 0)
            {
                return this.ListaClientes.Peek();
            }
            return null;
        }

        /// <summary>
        /// Devuelve el alquiler al que pertenece el cliente pasado por parámetro
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public Alquiler GetAlquilerCliente(Cliente cliente)
        {
            foreach (Alquiler alquiler in this.ListaAlquileres)
            {
                if (cliente == alquiler)
                    return alquiler;
            }
            return null;
        }
        

        /// <summary>
        /// Asigna un Cliente al Equipo pasado por parámetro, indicando el tiempo de uso
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="nombre"></param>
        /// <param name="tiempoUso"></param>
        public void AsignarEquipo(Jugador jugador, string nombre, double tiempoUso)
        {
            Alquiler alq = new Alquiler(jugador, GetEquipo(nombre));

            jugador.HoraInicial = DateTime.Now;
            jugador.HoraFinal = jugador.HoraInicial.AddSeconds(tiempoUso);
            ConfirmarAlquiler(alq.Equipo, alq, jugador);
        }

        /// <summary>
        /// Asigna un Cliente al Telefono pasado por parámetro
        /// </summary>
        /// <param name="llamador"></param>
        /// <param name="telefono"></param>
        public void AsignarEquipo(Llamador llamador, Telefono telefono)
        {
            Alquiler alq = new Alquiler(llamador, telefono);
            llamador.HoraInicial = DateTime.Now;
            ConfirmarAlquiler(alq.Equipo, alq, llamador);

        }

        /// <summary>
        /// Confirma el alquiler del Equipo, colocando no disponible al mismo, y elmiminando el cliente de la lista de espera
        /// </summary>
        /// <param name="equipo"></param>
        /// <param name="alquiler"></param>
        /// <param name="cliente"></param>
        public void ConfirmarAlquiler(Equipo equipo, Alquiler alquiler, Cliente cliente)
        {
            equipo.CambiarEstado();
            this.ListaAlquileres.Add(alquiler);
            ClienteAtendido();
        }

        /// <summary>
        /// Remueve el Cliente de la lista de Clientes
        /// </summary>
        /// <param name="cliente"></param>
        public void ClienteAtendido()
        {
            ListaClientes.Dequeue();
        }

        /// <summary>
        /// Devuelve el objeto del tipo Equipo, según nombre obtenido por parámetro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Equipo GetEquipo(string nombre)
        {
            foreach (Equipo equipo in this.ListaEquipos)
            {
                if (nombre == equipo.Nombre)
                    return equipo;
            }
            return null;
        }

        /// <summary>
        /// Devuelve el objeto del tipo Telefono, según el primero disponible
        /// </summary>
        /// <returns></returns>
        public Telefono GetTelefono()
        {
            foreach (Equipo equipo in this.ListaEquipos)
            {
                if (equipo is Telefono && ((Telefono)equipo).Disponible)
                    return (Telefono)equipo;
            }
            return null;
        }

        /// <summary>
        /// Devuelve el Alquiler de la lista de alquileres, según el nombre obtenido por parámetro.
        /// </summary>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public Alquiler GetAlquiler(Equipo equipo)
        {
            foreach(Alquiler alquiler in listaAlquileres)
            {
                if(alquiler.Equipo == equipo && alquiler.Costo == 0)
                {
                    return alquiler;
                }
            }
            return null;
        }

        /// <summary>
        /// Finala el alquiler de un equipo.
        /// </summary>
        /// <param name="alquiler"></param>
        public static void FinalizarAlquiler(Alquiler alquiler)
        {
            alquiler.Equipo.CambiarEstado();
        }
    }
}
