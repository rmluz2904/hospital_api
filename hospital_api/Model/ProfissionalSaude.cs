namespace hospital_api.Model
{
    public class ProfissionalSaude
    {     
            public int ProfissionalSaudeId { get; set; }
            public int NumeroMecanografico { get; set; }
            public string NomeProfissionalSaude { get; set; }
            public string Especialidade { get; set; }
            public string Hospital { get; set; }
    }
}
