using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoDetalles
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }

        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Valor{get; set; }
        public decimal Itbis { get; set; }

       public ProductoDetalles()
        {
            Id = 0;
            VentaId = 0;
            Producto = string.Empty;
            Cantidad = 0;
            Valor = 0;
            Itbis = 0;
        }

    }
}
