using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class CiberCafe
    {
        public Queue<Cliente> listaDeClientes;
        public List<Cliente> ListaClientesFacturados;

        public CiberCafe()
        {
            this.listaDeClientes = new Queue<Cliente>();
            this.ListaClientesFacturados = new List<Cliente>();
        }

        public Computadora AsignarEquipo(Cliente cliente, Computadora computadora)
        {
            cliente.equipo = computadora;
            computadora.clienteEnUso = cliente;
            return computadora;
        }

        public Telefono AsignarEquipo(Cliente cliente, Telefono telefono)
        {
            cliente.equipo = telefono;
            telefono.clienteEnUso = cliente;
            return telefono;
        }

        public string LlamarCliente(Equipo equipo)
        {
            Cliente cliente = new Cliente();
            cliente = this.ProximoCliente(listaDeClientes);
            if(cliente != null)
            {
                if (cliente.accion is Cliente.EAccion.Llamar)
                {
                    
                    this.AsignarEquipo(cliente, (Telefono)equipo);
                }

                if (cliente.accion is Cliente.EAccion.Viciar)
                {
                    this.AsignarEquipo(cliente, (Computadora)equipo);
                }
                cliente.HoraInicial = DateTime.Now;
                return ($"Se agrego el cliente {cliente.Mostrar()} al equipo {equipo}");
            }
            return "No hay más clientes en la lista";
        }
        public Cliente ProximoCliente(Queue<Cliente> listaClientes)
        {
            if (listaClientes.Count >0)
            {
                return listaClientes.Dequeue();
            }
            return null;
        }

        public string Cobrar(Equipo equipo)
        {
            return equipo.CalcularCosto().ToString();
        }


        public float CalcularCosto(Equipo equipo)
        {
            if (equipo is Telefono)
            {
                return 5;
            }

            if (equipo is Computadora)
            {
                return (float)0.50;
            }

            return 0;
        }
    }
}
