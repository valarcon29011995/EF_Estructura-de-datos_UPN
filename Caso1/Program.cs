using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Creando los pedidos.....\n");
            Pedido p1 = new Pedido(001, 3, 12, "Pollo Saltado", "Miriam");
            Pedido p2 = new Pedido(002, 2, 13, "Chaufa", "Victor");
            Pedido p3 = new Pedido(003, 1, 14, "Makis", "Ricardo");
            Pedido p4 = new Pedido(004, 4, 15, "Ají de Gallina", "Manuel");
            Pedido p5 = new Pedido(005, 5, 16, "Pollo Frito", "Pamela");
            ArbolBinario arbolbin = new ArbolBinario();
            Console.Write("Ingresando los pedidos al sistema.....\n");
            arbolbin.InsertarNodo(p1);
            arbolbin.InsertarNodo(p2);
            arbolbin.InsertarNodo(p3);
            arbolbin.InsertarNodo(p4);
            arbolbin.InsertarNodo(p5);

            Console.WriteLine("Listando los pedidos en preorden....");
            arbolbin.Preorden(arbolbin.GetRaiz());
            Console.WriteLine("");
            Console.WriteLine("Listando los pedidos en inorden....");
            arbolbin.Inorden(arbolbin.GetRaiz());
            Console.WriteLine("");
            Console.WriteLine("Listando los pedidos en postorden....");
            arbolbin.Postorden(arbolbin.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("***********AGREGANDO NUEVO PEDIDO**********");
            Pedido p6 = new Pedido(006, 0, 35, "Estofado de carne", "Heidi");
            arbolbin.InsertarNodo(p6);
            Console.WriteLine("************************************************");

            Console.WriteLine("Listando los pedidos en postorden....");
            arbolbin.Postorden(arbolbin.GetRaiz());
            Console.WriteLine("");
            Console.WriteLine("Listando los pedidos en inorden....");
            arbolbin.Inorden(arbolbin.GetRaiz());
            Console.WriteLine("");
            Console.WriteLine("Listando los pedidos en preorden....");
            arbolbin.Preorden(arbolbin.GetRaiz());
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
