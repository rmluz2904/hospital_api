using System.ComponentModel.DataAnnotations;

namespace hospital_api.ViewModel
{
    public class CriarPaciente
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public int NIF { get; set; }
        [Required]
        public string Morada { get; set; } 
    }
}
