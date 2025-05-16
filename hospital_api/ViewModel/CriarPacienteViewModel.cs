using hospital_api.Validações;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace hospital_api.ViewModel
{
    public class CriarPaciente
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        [ValidacaoDataNascimento]
        public DateTime DataNascimento { get; set; }
        [Required]
        [ValidacaoNIF]
        public int NIF { get; set; }
        [Required]
        public string Morada { get; set; } 
    }
}
