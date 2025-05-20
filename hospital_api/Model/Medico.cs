using Microsoft.EntityFrameworkCore;

namespace hospital_api.Model

{
    //isto significa que a classe Medico herda da classe ProfissionalSaude
    public class Medico : ProfissionalSaude
    {
        public int MedicoId { get; set; }
        public int NumeroOrdemMedicos { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
