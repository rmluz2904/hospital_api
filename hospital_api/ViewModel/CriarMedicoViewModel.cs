using hospital_api.Validações;
using System.ComponentModel.DataAnnotations;

namespace hospital_api.ViewModel
{
    public class CriarMedico
    {
        [Required]
        public int NumeroMecanografico { get; set; }
        [Required]
        public string NomeProfissionalSaude { get; set; }
        [Required]
        public string Especialidade { get; set; }
        [Required]
        public string Hospital { get; set; }
        [Required]
        public int NumeroOrdemMedicos { get; set; }
    }
}
