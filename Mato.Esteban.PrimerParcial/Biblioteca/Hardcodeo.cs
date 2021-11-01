using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcodeo
    {
        public static void InicializarEquipos(CiberCafe ciberCafe)
        {
            Computadora C1 = new Computadora("C1", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office, Computadora.ESoftware.Ares, Computadora.ESoftware.Msn },
                                            new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares, Computadora.EPerifericos.Camara, Computadora.EPerifericos.Microfono },
                                            new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.CounterStrike, Computadora.EJuegos.Diablo, Computadora.EJuegos.Muu, Computadora.EJuegos.NeedForSpeed , Computadora.EJuegos.PES },
                                            Computadora.EProcesador.Intel, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Buena);

            Computadora C2 = new Computadora("C2", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office},
                                            new List<Computadora.EPerifericos>() { },
                                            new List<Computadora.EJuegos>() { },
                                            Computadora.EProcesador.Intel, Computadora.ERAM.Dos, Computadora.EPlacaVideo.Mala);

            Computadora C3 = new Computadora("C3", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office },
                                            new List<Computadora.EPerifericos>() { },
                                            new List<Computadora.EJuegos>() { },
                                            Computadora.EProcesador.Amd, Computadora.ERAM.Dos, Computadora.EPlacaVideo.Mala);

            Computadora C4 = new Computadora("C4", new List<Computadora.ESoftware>() { },
                                            new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares, Computadora.EPerifericos.Microfono },
                                            new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.CounterStrike, Computadora.EJuegos.Diablo, Computadora.EJuegos.Muu, Computadora.EJuegos.NeedForSpeed, Computadora.EJuegos.PES },
                                            Computadora.EProcesador.Amd, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Buena);

            Computadora C5 = new Computadora("C5", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office, Computadora.ESoftware.Ares, Computadora.ESoftware.Msn },
                                            new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Camara},
                                            new List<Computadora.EJuegos>() {},
                                            Computadora.EProcesador.Amd, Computadora.ERAM.Cuatro, Computadora.EPlacaVideo.Media);

            Computadora C6 = new Computadora("C6", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office, Computadora.ESoftware.Ares, Computadora.ESoftware.Msn },
                                            new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Camara },
                                            new List<Computadora.EJuegos>() { },
                                            Computadora.EProcesador.Intel, Computadora.ERAM.Cuatro, Computadora.EPlacaVideo.Media);

            Computadora C7 = new Computadora("C7", new List<Computadora.ESoftware>() {  },
                                            new List<Computadora.EPerifericos>() { },
                                            new List<Computadora.EJuegos>() { },
                                            Computadora.EProcesador.Intel, Computadora.ERAM.Uno, Computadora.EPlacaVideo.Mala);

            Computadora C8 = new Computadora("C8", new List<Computadora.ESoftware>() { },
                                            new List<Computadora.EPerifericos>() { },
                                            new List<Computadora.EJuegos>() { },
                                            Computadora.EProcesador.Amd, Computadora.ERAM.Uno, Computadora.EPlacaVideo.Mala);

            Computadora C9 = new Computadora("C9", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office, Computadora.ESoftware.Ares, Computadora.ESoftware.Msn },
                                           new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares, Computadora.EPerifericos.Camara, Computadora.EPerifericos.Microfono },
                                           new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.PES},
                                           Computadora.EProcesador.Intel, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Media);

            Computadora C10 = new Computadora("C10", new List<Computadora.ESoftware>() { Computadora.ESoftware.Office, Computadora.ESoftware.Ares, Computadora.ESoftware.Msn },
                                            new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares, Computadora.EPerifericos.Camara, Computadora.EPerifericos.Microfono },
                                            new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.CounterStrike, Computadora.EJuegos.Diablo, Computadora.EJuegos.Muu, Computadora.EJuegos.NeedForSpeed, Computadora.EJuegos.PES },
                                            Computadora.EProcesador.Amd, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Buena);

            Telefono T1 = new Telefono("T1", "Cisco", Telefono.ETipo.Cable);
            Telefono T2 = new Telefono("T2", "Avaya", Telefono.ETipo.Cable);
            Telefono T3 = new Telefono("T3", "Avaya", Telefono.ETipo.Disco);
            Telefono T4 = new Telefono("T4", "Cisco", Telefono.ETipo.Disco);
            Telefono T5 = new Telefono("T5", "Cisco", Telefono.ETipo.Cable);


            ciberCafe.ListaEquipos.Add(C1);
            ciberCafe.ListaEquipos.Add(C2);
            ciberCafe.ListaEquipos.Add(C3);
            ciberCafe.ListaEquipos.Add(C4);
            ciberCafe.ListaEquipos.Add(C5);
            ciberCafe.ListaEquipos.Add(C6);
            ciberCafe.ListaEquipos.Add(C7);
            ciberCafe.ListaEquipos.Add(C8);
            ciberCafe.ListaEquipos.Add(C9);
            ciberCafe.ListaEquipos.Add(C10);

            ciberCafe.ListaEquipos.Add(T1);
            ciberCafe.ListaEquipos.Add(T2);
            ciberCafe.ListaEquipos.Add(T3);
            ciberCafe.ListaEquipos.Add(T4);
            ciberCafe.ListaEquipos.Add(T5);

        }
        public static void InicializarClientes(CiberCafe ciberCafe)
        {
            Jugador Cli1 = new Jugador("94874469", "JuanFer", "Quinteros", 28, Cliente.EAccion.Viciar,
                                        new List<Computadora.ESoftware>() { },
                                        new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares },
                                        new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.CounterStrike, Computadora.EJuegos.Diablo, Computadora.EJuegos.Muu, Computadora.EJuegos.NeedForSpeed , Computadora.EJuegos.PES },
                                        Computadora.EProcesador.Intel, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Buena);

            Jugador Cli2 = new Jugador("31280182", "Ignacio", "Scocco", 36, Cliente.EAccion.Viciar,
                                         new List<Computadora.ESoftware>() { },
                                        new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares , Computadora.EPerifericos.Microfono },
                                        new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.PES },
                                        Computadora.EProcesador.Intel, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Media);

            Jugador Cli3 = new Jugador("41492219", "Lucas", "Pratto", 33, Cliente.EAccion.Viciar, 
                                        new List<Computadora.ESoftware>() { Computadora.ESoftware.Msn },
                                        new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Auriculares, Computadora.EPerifericos.Microfono },
                                        new List<Computadora.EJuegos>() { Computadora.EJuegos.FIFA, Computadora.EJuegos.CounterStrike, Computadora.EJuegos.NeedForSpeed },
                                        Computadora.EProcesador.Intel, Computadora.ERAM.Ocho, Computadora.EPlacaVideo.Buena);

            Jugador Cli6 = new Jugador("92522794", "Enzo", "Francescoli", 59, Cliente.EAccion.Viciar,
                                        new List<Computadora.ESoftware>() { Computadora.ESoftware.Office },
                                        new List<Computadora.EPerifericos>() {  },
                                        new List<Computadora.EJuegos>() {  },
                                        Computadora.EProcesador.Amd, Computadora.ERAM.Uno, Computadora.EPlacaVideo.Mala);

            Jugador Cli7 = new Jugador("4991796", "Beto", "Alonso", 68, Cliente.EAccion.Viciar,
                                       new List<Computadora.ESoftware>() { Computadora.ESoftware.Office },
                                        new List<Computadora.EPerifericos>() { },
                                        new List<Computadora.EJuegos>() { },
                                        Computadora.EProcesador.Intel, Computadora.ERAM.Uno, Computadora.EPlacaVideo.Mala);

            Jugador Cli8 = new Jugador("24976295", "Marcelo", "Gallardo", 45, Cliente.EAccion.Viciar,
                                        new List<Computadora.ESoftware>() { Computadora.ESoftware.Msn },
                                        new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Camara },
                                        new List<Computadora.EJuegos>() { },
                                        Computadora.EProcesador.Amd, Computadora.ERAM.Cuatro, Computadora.EPlacaVideo.Media);

            Jugador Cli14 = new Jugador("23665680", "Matias", "Biscay", 47, Cliente.EAccion.Viciar,
                                        new List<Computadora.ESoftware>() { Computadora.ESoftware.Msn },
                                        new List<Computadora.EPerifericos>() { Computadora.EPerifericos.Camara },
                                        new List<Computadora.EJuegos>() { },
                                        Computadora.EProcesador.Intel, Computadora.ERAM.Cuatro, Computadora.EPlacaVideo.Media);

            Llamador Cli9 = new Llamador("23654344", "Ariel", "Ortega", 47, Cliente.EAccion.Llamar);
            Llamador Cli10 = new Llamador("24652793", "Fernando", "Cavenaghi", 38, Cliente.EAccion.Llamar);
            Llamador Cli11= new Llamador("23388424", "Marcelo", "Barovero", 37, Cliente.EAccion.Llamar);
            Llamador Cli12= new Llamador("24684521", "Ignacio", "Fernandez", 31, Cliente.EAccion.Llamar);
            Llamador Cli13= new Llamador("27424870", "Pablo", "Aimar", 41, Cliente.EAccion.Llamar);
            Llamador Cli4 = new Llamador("30678450", "Pity", "Martinez", 28, Cliente.EAccion.Llamar);
            Llamador Cli5 = new Llamador("32693911", "Franco", "Armani", 35, Cliente.EAccion.Llamar);

            ciberCafe.ListaClientes.Enqueue(Cli1);
            ciberCafe.ListaClientes.Enqueue(Cli5);
            ciberCafe.ListaClientes.Enqueue(Cli2);
            ciberCafe.ListaClientes.Enqueue(Cli3);
            ciberCafe.ListaClientes.Enqueue(Cli4);
            ciberCafe.ListaClientes.Enqueue(Cli9);
            ciberCafe.ListaClientes.Enqueue(Cli7);
            ciberCafe.ListaClientes.Enqueue(Cli10);
            ciberCafe.ListaClientes.Enqueue(Cli6);
            ciberCafe.ListaClientes.Enqueue(Cli11);
            ciberCafe.ListaClientes.Enqueue(Cli8);
            ciberCafe.ListaClientes.Enqueue(Cli12);
            ciberCafe.ListaClientes.Enqueue(Cli13);
            ciberCafe.ListaClientes.Enqueue(Cli14);

        }
    }
}
