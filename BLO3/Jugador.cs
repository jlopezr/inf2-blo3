using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLO3
{
    class Jugador
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public int Puntos { get; set; }


        public Jugador(String nombre, int edad, int puntos)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Puntos = puntos;
        }
    }
}
