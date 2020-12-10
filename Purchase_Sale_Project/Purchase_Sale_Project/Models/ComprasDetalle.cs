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
        [Required]
        public int ProductoId { get; set; }
        [Required]
        public float Cantidad { get; set; }
        [Required]
        public float Costo_Unidad { get; set; }
        public float Monto { get; set; }
        public float ITBIS { get; set; }

        [ForeignKey("ProductoId")]
        public Productos producto { get; set; }
    }
}
