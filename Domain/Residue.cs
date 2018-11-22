using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Residue
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório")]
        [MinLength(5, ErrorMessage = "Preencha no mínimo 5 caracteres")]
        public string Name { get; set; }
    }
}