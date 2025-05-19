namespace hospital_api.Model
{
    public class ProfissionalSaude
    {     
            public int ProfissionalSaudeId { get; set; }
            public int NumeroMecanografico { get; set; }
            public string NomeProfissionalSaude { get; set; }
            public int EspecialidadeId { get; set; }
            public Especialidade Especialidade { get; set; }
            public string Hospital { get; set; }
    }
}
