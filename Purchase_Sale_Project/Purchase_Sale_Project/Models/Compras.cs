using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public DateTime Fecha { get; set; }
        public float Total { get; set; }
        public int UsuarioId { get; set; }
        public int SuplidorId { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual List<Suplidores> Suplidor { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }
    }

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
