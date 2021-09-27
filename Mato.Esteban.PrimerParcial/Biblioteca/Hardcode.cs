using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcode
    {
        public static void InicializarCompu(Computadora computadora)
        {
            //Computadora.ESoftware[] software1 = { Computadora.ESoftware.Ares, Computadora.ESoftware.Msn };
            //Computadora.EJuegos[] juegos = { Computadora.EJuegos.FIFA, Computadora.EJuegos.PES };
            //Computadora.EPerifericos[] perifericos = { Computadora.EPerifericos.Auriculares, Computadora.EPerifericos.Microfono };

            List<Computadora.ESoftware> softwares = new List<Computadora.ESoftware>();
            softwares.Add(Computadora.ESoftware.Ares);
            softwares.Add(Computadora.ESoftware.Msn);

            computadora.ListadoSoftware = softwares;

            List<Computadora.EJuegos> juegos = new List<Computadora.EJuegos>();
            juegos.Add(Computadora.EJuegos.FIFA);
            juegos.Add(Computadora.EJuegos.PES);

            computadora.ListadoJuegos = juegos;

            List<Computadora.EPerifericos> perifericos = new List<Computadora.EPerifericos>();
            perifericos.Add(Computadora.EPerifericos.Auriculares);
            perifericos.Add(Computadora.EPerifericos.Microfono);

            computadora.ListadoPerifericos = perifericos;

            computadora.PlacaVideo = Computadora.EPlacaVideo.Buena;
            computadora.Ram = Computadora.ERAM.Ocho;
            computadora.Procesador = Computadora.EProcesador.Intel;
        }

        public static void InicializarCliente(Cliente cliente)
        {/*
            if (rbtnC1.Checked == true)
            {
                ciber.AsignarEquipo((Cliente)lstClientes.SelectedItem, C1);
                MessageBox.Show("C1");
            }
            if (rbtnC2.Checked == true)
            {
                ciber.AsignarEquipo((Cliente)lstClientes.SelectedItem, C2);
                MessageBox.Show("C2");
            }
            if (rbtnC3.Checked == true)
            {
                ciber.AsignarEquipo((Cliente)lstClientes.SelectedItem, C3);
                MessageBox.Show("C3");
            }
            if (rbtnT1.Checked == true)
            {
                ciber.AsignarEquipo((Cliente)lstClientes.SelectedItem, T1);
                MessageBox.Show("T1");
            }
            if (rbtnT2.Checked == true)
            {
                ciber.AsignarEquipo((Cliente)lstClientes.SelectedItem, T2);
                MessageBox.Show("T2");
            }*/
        }
    }
}
