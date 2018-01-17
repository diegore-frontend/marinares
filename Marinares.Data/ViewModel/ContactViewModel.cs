using System.ComponentModel.DataAnnotations;

namespace Marinares.Data.ViewModel
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Debes introducir un nombre para continuar.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debes introducir un mensaje para continuar.")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Debes introducir un correo electrónico para continuar.")]
        [EmailAddress(ErrorMessage = "Debes introducir un correo elctrónico valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debes introducir un número de teléfono para continuar.")]
        public string Phone { get; set; }
    }
}
