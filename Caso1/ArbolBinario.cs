using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierdo);
                Console.Write("Prioridad: {1}; Codigo ({0}); Costo: {2}; Pedido: {3}; Para el cliente: {4}", raiz.valor.Prioridad.ToString(), raiz.valor.ID.ToString(), raiz.valor.Costo.ToString(), raiz.valor.pedido, raiz.valor.Cliente);
                Console.Write("\n");
                Inorden(raiz.derecho);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.Write("Prioridad: {1}; Codigo ({0}); Costo: {2}; Pedido: {3}; Para el cliente: {4}", raiz.valor.Prioridad.ToString(), raiz.valor.ID.ToString(), raiz.valor.Costo.ToString(), raiz.valor.pedido, raiz.valor.Cliente);
                Console.Write("\n");
                Preorden(raiz.izquierdo);
                Preorden(raiz.derecho);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierdo);
                Postorden(raiz.derecho);
                Console.Write("Prioridad: {1}; Codigo ({0}); Costo: {2}; Pedido: {3}; Para el cliente: {4}", raiz.valor.Prioridad.ToString(), raiz.valor.ID.ToString(), raiz.valor.Costo.ToString(), raiz.valor.pedido, raiz.valor.Cliente);
                Console.Write("\n");
            }
        }

        public void InsertarNodo(Pedido x)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                valor = x
            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (x.Prioridad < puntero.valor.Prioridad)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }
    }
}
