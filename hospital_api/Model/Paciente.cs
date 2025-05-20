namespace hospital_api.Model
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NIF { get; set; }
        public string Morada { get; set; }
        public int CalcularIdade()
        {
            var hoje = DateTime.Today;
            var idade = hoje.Year - DataNascimento.Year;
            if (DataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
