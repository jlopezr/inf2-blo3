using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BLO3
{
    class Program
    {
        static Stack<String> salvarLista(string nombre, List<Jugador> lista, int n)
        {
            Stack<String> ret = new Stack<string>();
            StreamWriter w = File.CreateText(nombre);

            foreach (Jugador j in lista)
            {
                if (j.Puntos > n)
                {
                    ret.Push(j.Nombre);
                    w.WriteLine(j.Nombre + " " + j.Edad + " "+ j.Puntos);
                }
            }
            w.Close();

            if (ret.Count > 0) 
                return ret; 
            else 
                return null;
        }

        static void Main1(string[] args)
        { 

            //StreamReader r = File.OpenText("ganadores.txt");

            List<Jugador> lista = new List<Jugador>();
            int i = 0;
            bool fin = false;
            while (!fin)
            {
                String linea = Console.ReadLine();
                //String linea = r.ReadLine();
                if (linea == null || linea.Equals(""))
                {
                    fin = true;
                } else { 
                    String[] trozos = linea.Split(' ');
                    Jugador j = new Jugador(trozos[0], Convert.ToInt32(trozos[1]), Convert.ToInt32(trozos[2]));
                    lista.Add(j);
                    i++;
                }
            }
            Stack<String> resultado = salvarLista("ganadores.txt", lista, 50);
            if (resultado != null)
            {
                foreach (String s in resultado)
                {
                    Console.WriteLine(s);
                }
            }

        }

        static void Main2(String[] args)
        {
            List<Jugador> listaJugadores = new List<Jugador>();
            Queue<Jugador> colaJugadores = new Queue<Jugador>();
            Stack<Jugador> pilaJugadores = new Stack<Jugador>();

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Escribe los datos del jugador separados por blancos");
                String[] trozos = Console.ReadLine().Split(' ');
                Jugador j = new Jugador(trozos[0], Convert.ToInt32(trozos[1]), Convert.ToInt32(trozos[2]));
                listaJugadores.Add(j);
                i++;
            }

            foreach (Jugador j in listaJugadores)
            {
                if (j.Puntos > 10)
                {
                    colaJugadores.Enqueue(j);
                }
                else
                {
                    pilaJugadores.Push(j);
                }
            }

            while (pilaJugadores.Count > 0)
            {
                Jugador j = pilaJugadores.Pop();
                Console.WriteLine("{0} {1} {2}", j.Nombre, j.Edad, j.Puntos);
            }
        }

    }
}
