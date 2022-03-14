using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaElBosquecito.Areas.Usuarios.Models
{
    public class InputModelRegistrar
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string NID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "El formato del telefono ingresado no es valido.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [EmailAddress(ErrorMessage = "La direccion de correo electronico Ingresada no es valida.")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser de al menos {2} caracteres.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
