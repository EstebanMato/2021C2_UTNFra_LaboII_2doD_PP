using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class CiberCafe
    {
        public Queue<Cliente> listaDeClientes;

        public CiberCafe()
        {
            this.listaDeClientes = new Queue<Cliente>();
        }

        public Computadora AsignarEquipo(Cliente cliente, Computadora computadora)
        {
            cliente.equipo = computadora;
            computadora.enUso = true;
            return computadora;
        }

        public Telefono AsignarEquipo(Cliente cliente, Telefono telefono)
        {
            cliente.equipo = telefono;
            telefono.enUso = true;
            return telefono;
        }

        public string LlamarCliente(Equipo equipo)
        {
            //depende que contenga el cliente llamo a uno o al otro
            Cliente c1 = new Cliente();
            c1 = this.ProximoCliente(listaDeClientes);
            if(c1 != null)
            {
                if (c1.accion is Cliente.EAccion.Llamar)
                {
                    this.AsignarEquipo(c1, (Telefono)equipo);
                }

                if (c1.accion is Cliente.EAccion.Viciar)
                {
                    this.AsignarEquipo(c1, (Computadora)equipo);
                }

                return ($"Se agrego el cliente {c1.Mostrar()} al equipo {equipo}");
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

        public float Cobrar(Equipo equipo)
        {
            return CalcularCosto(equipo);
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
