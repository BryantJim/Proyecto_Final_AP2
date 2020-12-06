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
        public int SuplidorId { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual List<Suplidores> Suplidor { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuarios usuarios { get; set; }
    }
}
