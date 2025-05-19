namespace hospital_api.Model
{
    //isto significa que a classe Enfermeiro herda da classe ProfissionalSaude
    public class Enfermeiro : ProfissionalSaude
    {
        public int IdEnfermeiro { get; set; }
        public int NumeroOrdemEnfermeiros { get; set; }
    }
}
