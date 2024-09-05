using Ejercicio3TP8.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3TP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos,
atributos y métodos necesarios para este sistema.*/

            Producto producto1 = new Producto();
            Pedidos pedido1 = new Pedidos();
            Clientes cliente1 = new Clientes();

            producto1.Nombre = "Teclado";
            producto1.Precio = 94000;
            producto1.Descripcion = "Teclado bluetooth Satechi Slim X3 Bluetooth Backlit Keyboard QWERTY español España color space gray";
            producto1.Stock = 10;

            pedido1.Identificador = "EFP20X";
            pedido1.Fechadepedido = "16 de Mayo de 2024";
            pedido1.Cliente = "Fuenzalida Ignacio";
            pedido1.Preciototal = 105000;

            cliente1.Nombre = "Venicio Sol";
            cliente1.Direcciondenvio = "Bodega PATAGUA";
            cliente1.Correo = "veniciosol32@gmail.com";

            Console.WriteLine("Nombre del producto: " + producto1.Nombre);
            Console.WriteLine("Precio: " + producto1.Precio);
            Console.WriteLine("Descripcion del producto: " + producto1.Descripcion);
            Console.WriteLine("Cantidad en stock: " + producto1.Stock);
            Console.WriteLine();
            Console.WriteLine("Codigo: " + pedido1.Identificador);
            Console.WriteLine("Fecha de pedido: " + pedido1.Fechadepedido);
            Console.WriteLine("Nombre del cliente: " + pedido1.Cliente);
            Console.WriteLine("Precio total: " + pedido1.Preciototal);
            Console.WriteLine();
            Console.WriteLine("Nombre: " + cliente1.Nombre);
            Console.WriteLine("Direccion de envio: " + cliente1.Direcciondenvio);
            Console.WriteLine("Dirrecion de correo electronico: " + cliente1.Correo);

            Console.ReadKey();
        }
    }
}
