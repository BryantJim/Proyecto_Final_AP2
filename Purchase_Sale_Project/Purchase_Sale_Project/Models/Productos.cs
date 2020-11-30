using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public float Cantidad { get; set; }
        public float Costo_Unidad { get; set; }
        public float Precio { get; set; }
        public float ITBIS { get; set; }
        public int UsuarioId { get; set; }
        public int SuplidorId { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual List<Suplidores> Suplidor { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual List<Categorias> Categoria { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }
    }
}
