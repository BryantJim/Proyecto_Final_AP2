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
        [Required]
        public int SuplidorId { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("CompraId")]
        public List<ComprasDetalle> Detalle { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuarios usuarios { get; set; }
    }
}
