using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4TP8.Modelo
{
    internal class Curso
    {
        private int codigo;
        private string nombre;
        private string profesor;
        private string materia;

        public Curso()
        {

        }
        public Curso(string nomb, int cod)
        {
            nombre = nomb;
            codigo = cod;
        }

        public Curso(int cod, string nom, string prof, string mat)
        {
            Codigo = cod;
            Nombre = nom;
            Profesor = prof;
            Materia = mat;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Profesor { get => profesor; set => profesor = value; }
        public string Materia { get => materia; set => materia = value; }
    }
}
