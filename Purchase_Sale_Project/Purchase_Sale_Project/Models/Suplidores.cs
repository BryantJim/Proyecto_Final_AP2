using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId { get; set; }
        [Required(ErrorMessage = "Campo nombres es requerido")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Campo dirección es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Campo correo es requerido")]
        [EmailAddress]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Campo teléfono es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo celular es requerido")]
        public string Celular { get; set; }
   
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual Productos Producto { get; set; }

        [ForeignKey("SuplidorId")]
        public List<Compras> compra { get; set; }
    }
}
