using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Campo nombres es requerido")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Campo apellidos es requerido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Campo cédula es requerido")]
        [RegularExpression(@"^\d{3}[- ]?\d{7}[- ]?\d{1}$",ErrorMessage = "Cédula no válida. 000-0000000-0")]
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Campo teléfono es requerido")]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "Teléfono no válido.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo celular es requerido")]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "Celular no válido.")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Campo dirección es requerido")]
        public string Direccion { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios usuarios { get; set; }
    }
}
