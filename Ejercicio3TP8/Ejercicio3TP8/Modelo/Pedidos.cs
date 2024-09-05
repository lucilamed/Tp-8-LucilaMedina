using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3TP8.Modelo
{
    internal class Pedidos
    {
        private string identificador;
        private string fechadepedido;
        private string cliente;
        private int preciototal;

        public Pedidos()
        {

        }
        public Pedidos(string clientes, string fech)
        {
            cliente = clientes;
            fechadepedido = fech;
        }
        public Pedidos(string identif, string fecha, string client, int preciot)
        {
            Identificador = identif;
            Fechadepedido = fecha;
            Cliente = client;
            Preciototal = preciot;
        }

        public string Identificador { get => identificador; set => identificador = value; }
        public string Fechadepedido { get => fechadepedido; set => fechadepedido = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int Preciototal { get => preciototal; set => preciototal = value; }
    }
}
