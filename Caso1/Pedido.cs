using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Pedido
    {
        public int ID;
        public int Prioridad;
        public int Costo;
        public string pedido;
        public string Cliente;

        public Pedido(int ID, int Prioridad, int Costo, string pedido, string Cliente)
        {
            this.ID = ID;
            this.Prioridad = Prioridad;
            this.Costo = Costo;
            this.pedido = pedido;
            this.Cliente = Cliente;
        }
    }
}
