namespace hospital_api.Model
{
    public class Especialidade
    {
        public int EspecialidadeId { get; set; }
        public string Nome { get; set; }

        // lista de médicos que têm esta especialidade
        public ICollection<Medico> Medicos { get; set; }
    }
}
