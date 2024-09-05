using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP8.Modelo2._8
{
    internal class Pasajero
    {
        private string nombre;
        private int numdpasajero;
        private string nacionalidad;

        public Pasajero()
        {

        }
        public Pasajero(string nomb)
        {
            nombre = nomb;
        }
        public Pasajero(string nom, int numpas, string nacido)
        {
            nombre = nom;
            numdpasajero = numpas;
            nacionalidad = nacido;

        }


        public string Nombre { get => nombre; set => nombre = value; }
        public int Numdpasajero { get => numdpasajero; set => numdpasajero = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
