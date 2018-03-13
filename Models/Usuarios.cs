using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoValidacion.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage ="Campo obligatorio")]
        [RegularExpression("[A-Za-z]*",ErrorMessage ="Solo se permite letras")]
        public string Nombre { get; set; }

        [RegularExpression("[0-9]*", ErrorMessage ="Solo permite números")]
        [StringLength(10,ErrorMessage ="Solo diez caracteres")]
        public string Password { get; set; }

        [Range(18,90, ErrorMessage ="Solo se permiten mayores de 18")]
        public string Edad { get; set; }
    }
}