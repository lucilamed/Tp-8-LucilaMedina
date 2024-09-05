using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1TP8.Modelo
{
    internal class Libro
    {
        private bool dispon { get; set; }

        private string nombre;
        private string autor;
        private int codigo;
        private string editorial;

        public Libro()
        {

        }
        public Libro(string nom, string aut)//constructor de la clase, da los valores a los de linea 10 a 15.
        {
            Nombre = nom;
            Autor = aut;

        }
        public Libro(bool dis, string nomb, string aut, int cod, string edi)
        {
            Dispon = dis;
            Nombre = nomb;
            Autor = aut;
            Codigo = cod;
            Editorial = edi;

        }
        public double precio { get; set; }

        public bool Dispon { get => dispon; set => dispon = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
    }
}
