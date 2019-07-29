using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 public class Ventas
    {
        [Key]

        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public decimal Devuelta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Itbis { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
       
        public virtual List<ProductoDetalles> Productos { get; set;}
    

        public Ventas()
        {
            VentaId = 0;
            ClienteId =0;
            Valor = 0;
            Devuelta = 0;
            SubTotal = 0;
            Itbis = 0;
            Precio = 0;
            Total = 0;
            Productos = new List<ProductoDetalles>();
            Fecha = DateTime.Now;
        }



    }
}
