using hospital_api.Data;
using hospital_api.DB;
using hospital_api.Model;
using hospital_api.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicosController : ControllerBase
    {
        private static int _IdMedico = 1;
        private static readonly List<Medico> _medicos = new();
        private readonly ApplicationDbContext _context;

        public MedicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CriarMedico")]
        public IActionResult CriarMedico(CriarMedicoViewModel medicoDto)
        {
            var medico = new Medico
            {
                IdMedico = _IdMedico++,
                NumeroOrdemMedicos = medicoDto.NumeroOrdemMedicos,
                NumeroMecanografico = medicoDto.NumeroMecanografico,
                NomeProfissionalSaude = medicoDto.NomeProfissionalSaude,
                Especialidade = medicoDto.Especialidade,
                Hospital = medicoDto.Hospital
            };

            _medicos.Add(medico);

            return Ok("Médico criado com sucesso!");
        }
        [HttpGet("ProcurarMedico")]
        public ActionResult<VerMedico> ProcurarMedico(int idMedico)
        {
            var medico = _medicos.Find(m => m.IdMedico == idMedico);
            if (medico == null)
            {
                return NotFound("Médico não foi encontrado");
            }

            var medicoVm = new VerMedico
            {
                IdMedico = medico.IdMedico,
                NumeroOrdemMedicos = medico.NumeroOrdemMedicos,
                NumeroMecanografico = medico.NumeroMecanografico,
                NomeProfissionalSaude = medico.NomeProfissionalSaude,
                Especialidade = medico.Especialidade,
                Hospital = medico.Hospital
            };

            return Ok(medicoVm);
        }
        [HttpGet("Especialidades")]
        public IActionResult ObterEspecialidades()
        {
            return Ok(Especialidades.ListaEspecialidades);
        }

    }
}
