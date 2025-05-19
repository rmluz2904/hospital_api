using Microsoft.EntityFrameworkCore;

namespace hospital_api.Model

{
    //isto significa que a classe Medico herda da classe ProfissionalSaude
    public class Medico : ProfissionalSaude
    {
        public int IdMedico { get; set; }
        public int NumeroOrdemMedicos { get; set; }
    }
}
