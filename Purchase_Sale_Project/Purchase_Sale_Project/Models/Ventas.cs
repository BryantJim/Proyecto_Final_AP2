using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public float Total { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual List<Clientes> Cliente { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }
    }

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
