using Ejercicio4TP8.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4TP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Una universidad desea crear un sistema para la gestión de cursos y estudiantes. Cada curso
tiene un código, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre,
número de matrícula y el año de cursado. El sistema debe permitir la inscripción y des
inscripción de estudiantes en cursos, así como la visualización de la lista de estudiantes por
curso. Identifica los objetos, atributos y métodos necesarios para implementar este sistema.*/

            Curso curso1 = new Curso();
            Estudiantes estudiante1 = new Estudiantes();

            curso1.Codigo = 11673428;
            curso1.Nombre = "7mo de Informatica";
            curso1.Profesor = "Lucas Garcia";
            curso1.Materia = "Electricidad";

            estudiante1.Nombre = "Elias Mena";
            estudiante1.Matricula = 018;
            estudiante1.Año_cursado = "7mo de Informatica";

            Console.WriteLine("Codigo: " + curso1.Codigo);
            Console.WriteLine("Nombre: " + curso1.Nombre);
            Console.WriteLine("Profesor: " + curso1.Profesor);
            Console.WriteLine("Materia que dicta: " + curso1.Materia);
            Console.WriteLine();
            Console.WriteLine("Nombre del estudiante: " + estudiante1.Nombre);
            Console.WriteLine("Numero de matricula: " + estudiante1.Matricula);
            Console.WriteLine("Año de cursado: " + estudiante1.Año_cursado);

            Console.ReadKey();
        }
    }
}
