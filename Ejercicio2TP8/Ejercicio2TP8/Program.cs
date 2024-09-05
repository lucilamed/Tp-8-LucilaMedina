using Ejercicio2TP8.Modelo2._8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vuelo vuelo1 = new Vuelo();
            Pasajero pasajero1 = new Pasajero();

            vuelo1.Numero = 18;
            vuelo1.Fdsalida = "16 de Octubre del 2024";
            vuelo1.Destino = "Dubai";
            vuelo1.Precio = 6000000;

            pasajero1.Nombre = "Medina Lucila";
            pasajero1.Numdpasajero = 24;
            pasajero1.Nacionalidad = "Argentino";

            Console.WriteLine("Numero de vuelo: " + vuelo1.Numero);
            Console.WriteLine("Fecha de salida: " + vuelo1.Fdsalida);
            Console.WriteLine("Destino: " + vuelo1.Destino);
            Console.WriteLine("Precio del vuelo: " + vuelo1.Precio);
            Console.WriteLine();
            Console.WriteLine("Nombre del pasajero: " + pasajero1.Nombre);
            Console.WriteLine("NUmero de pasajero: " + pasajero1.Numdpasajero);
            Console.WriteLine("Nacionalidad: " + pasajero1.Nacionalidad);

            Console.ReadKey();
        }
    }
}
