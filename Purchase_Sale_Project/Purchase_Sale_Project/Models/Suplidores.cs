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
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*",ErrorMessage = "Email no válido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Campo teléfono es requerido")]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "Teléfono no válido.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo celular es requerido")]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "Celular no válido.")]
        public string Celular { get; set; }
   
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }


    }
}
