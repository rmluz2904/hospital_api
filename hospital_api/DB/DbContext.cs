using hospital_api.Model;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Enfermeiro> Enfermeiros { get; set; }
        public DbSet<Hospital> Hospitais { get; set; }
        public DbSet<ProfissionalSaude> ProfissionaisSaude { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
    }

}

