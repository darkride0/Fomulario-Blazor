using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class Utilizador
    {
        [Required(ErrorMessage = "O primeiro nome é obrigatório.")]
        [StringLength(10, ErrorMessage = "O primeiro nome é muito longo.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        [StringLength(10, ErrorMessage = "O sobrenome é muito longo.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "A idade é obrigatória.")]
        [Range(18, 100, ErrorMessage = "A idade deve ser maior que 18")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O nome do utilizador é obrigatório.")]
        [MinLength(4, ErrorMessage = "O nome do utilizador deve ter no mínimo 4 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato do email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O perfil do utilizador é obrigatório")]
        public string Perfil { get; set; }

        [Required(ErrorMessage = "A senha deve ser informada.")]
        [MinLength(8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "A confirmação da senha é obrigatória.")]
        [Compare(nameof(Password), ErrorMessage = "A senha não confere")]
        public string ConfirmaPassword { get; set; } = string.Empty;
    }
}
