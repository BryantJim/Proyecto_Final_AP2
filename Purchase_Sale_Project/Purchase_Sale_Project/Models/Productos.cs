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
        [Required(ErrorMessage = "Campo nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo categoria es requerido")]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una categoria")]
        public int CategoriaId { get; set; }
        public float Cantidad { get; set; }
        public float Costo_Unidad { get; set; }
        [Required(ErrorMessage = "Campo precio es requerido")]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar un precio mayor a 0")]
        public float Precio { get; set; }
        [Required(ErrorMessage = "Campo ITBIS es requerido")]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar un ITBIS")]
        public float ITBIS { get; set; }
        [Required(ErrorMessage = "Campo suplidor es requerido")]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una suplidor")]
        public int SuplidorId { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categorias Categoria { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual Suplidores Suplidor { get; set; }

        [ForeignKey("ProductoId")]
        public List<ComprasDetalle> detalles { get; set; }
    }
}
