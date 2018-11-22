using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [MinLength(5, ErrorMessage = "Preencha no mínimo 5 caracteres")]
        public string Name{ get; set; }
    }
}