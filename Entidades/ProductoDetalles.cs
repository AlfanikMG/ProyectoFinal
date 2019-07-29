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

        public int Cantidad { get; set; }
        public decimal Valor{get; set; }

       public ProductoDetalles()
        {
            Id = 0;
            VentaId = 0;
            Cantidad = 0;
            Valor = 0;
        }

    }
}
