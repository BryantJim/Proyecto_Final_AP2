using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "Campo nombre es requerido")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Productos Producto { get; set; }

    }
}
