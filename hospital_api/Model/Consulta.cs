namespace hospital_api.Model
{
    public class Consulta
    {
        public int ConsultaId { get; set; }

        // Relacionamento com o Paciente
        public int PacienteId { get; set; }
        public virtual Paciente Paciente { get; set; }

        // Relacionamento com o Médico
        public int MedicoId { get; set; }
        public virtual Medico Medico { get; set; }

        public DateTime DataHora { get; set; }

        public string Status { get; set; }  // Ex: "Agendada", "Confirmada", "Cancelada", "Reagendada"

        public string Observacao { get; set; } // Observações adicionais
    }
}
