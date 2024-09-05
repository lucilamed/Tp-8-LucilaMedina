using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3TP8.Modelo
{
    internal class Producto
    {
         private string nombre;
        private int precio;
        private string descripcion;
        private int stock;

        public Producto()
        {

        }
        public Producto(string nomb, string descrip)
        {
            nombre = nomb;
            descripcion = descrip;
        }
        public Producto(string nom, int prec, string descrp, int sto)
        {
            Nombre = nom;
            Precio = prec;
            Descripcion = descrp;
            Stock = sto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
