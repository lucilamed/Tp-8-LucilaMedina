using Ejercicio1TP8.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1TP8
{
    internal class Program
    {
        static void Main(string[] args)
            /*1. Una biblioteca digital ofrece una amplia variedad de libros a sus usuarios registrados. Los
usuarios pueden buscar libros, leer descripciones, ver la disponibilidad y, si están registrados,
pueden pedir prestados los libros. Los libros pueden estar disponibles en formato digital o físico.
Cada vez que un usuario pide prestado un libro, se registra la fecha de préstamo y la fecha de
devolución prevista. Además, la biblioteca tiene un sistema para enviar recordatorios a los
usuarios cuando se acerca la fecha de devolución de un libro.*/

        {
            Libro libro1 = new Libro();
            

            libro1.Dispon = false;
            libro1.Nombre = "Cuentos y chistes";
            libro1.Autor = "Carlos";
            libro1.Codigo = 5236;
            libro1.Editorial = "Planeta";

            Console.WriteLine("Libro: " + libro1.Nombre);
            Console.WriteLine("Autor: " + libro1.Autor);
            Console.WriteLine("Editorial: " + libro1.Editorial);
            Console.WriteLine("Codigo: " + libro1.Codigo);
            Console.ReadKey();
        }
    }
}
