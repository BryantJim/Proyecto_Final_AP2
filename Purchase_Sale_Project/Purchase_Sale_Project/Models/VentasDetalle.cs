using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public float Descuento { get; set; }
        public float Cantidad { get; set; }
        public float Monto { get; set; }
        public float ITBIS { get; set; }

        [ForeignKey("VentaId")]
        public virtual List<Ventas> Venta { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Productos Producto { get; set; }
    }
}
