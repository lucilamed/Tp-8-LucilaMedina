using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP8.Modelo2._8
{
    internal class Vuelo
    {
        private int numero;
        private string fdsalida;
        private string destino;
        private double precio;

        public Vuelo()
        {

        }
        public Vuelo(int num1, double precio_)
        {
            numero = num1;
            precio = precio_;
        }

        public Vuelo(int num, string salida, string dest, double prec)
        {
            Numero = num;
            Fdsalida = salida;
            Destino = dest;
            Precio = prec;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Fdsalida { get => fdsalida; set => fdsalida = value; }
        public string Destino { get => destino; set => destino = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
