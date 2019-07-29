using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntradaInventario
    {
        [key]
        public string Producto {get; set;}
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }


        public EntradaInventario()
        {
            Producto = string.Empty;
            Cantidad = 0;
            Fecha = DateTime.Now;
        }
        
    }
}
