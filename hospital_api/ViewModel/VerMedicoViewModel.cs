using System.ComponentModel.DataAnnotations;

namespace hospital_api.ViewModel
{
    public class VerMedico
    {
        public int IdMedico { get; set; }
        public int NumeroMecanografico { get; set; }
        public string NomeProfissionalSaude { get; set; }
        public string EspecialidadeNome { get; set; }
        public string Hospital { get; set; }
        public int NumeroOrdemMedicos { get; set; }
    }
}
