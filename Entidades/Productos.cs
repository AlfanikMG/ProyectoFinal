using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Productos
    {
        [Key]

        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set;}
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set;}
        public int Existencia { get; set; }
        public decimal Itbis { get; set; }
        public decimal Descuento { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;
            Existencia = 0;
            Itbis = 0;
            Descuento = 0;
        }




    }
}
