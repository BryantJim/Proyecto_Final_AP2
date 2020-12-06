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
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual List<Clientes> Cliente { get; set; }
        
        public int UsuarioId { get; set; }
        public virtual Usuarios usuarios { get; set; }
    }
}
