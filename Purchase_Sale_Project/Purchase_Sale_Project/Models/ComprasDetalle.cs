using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ComprasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public float Cantidad { get; set; }
        public float Costo_Unidad { get; set; }
        public float Monto { get; set; }
        public float ITBIS { get; set; }

        [ForeignKey("CompraId")]
        public virtual List<Compras> Compra { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Productos Producto { get; set; }
    }
}
