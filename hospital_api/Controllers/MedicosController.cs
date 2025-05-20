using hospital_api.DB;
using hospital_api.Model;
using hospital_api.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CriarMedico")]
        public async Task<IActionResult> CriarMedico([FromBody] CriarMedico medicoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Verifica se a especialidade existe
            var especialidade = await _context.Especialidades.FindAsync(medicoDto.EspecialidadeId);
            if (especialidade == null)
                return BadRequest("Especialidade inválida.");

            var medico = new Medico
            {
                NumeroOrdemMedicos = medicoDto.NumeroOrdemMedicos,
                NumeroMecanografico = medicoDto.NumeroMecanografico,
                NomeProfissionalSaude = medicoDto.NomeProfissionalSaude,
                EspecialidadeId = medicoDto.EspecialidadeId,
                Hospital = medicoDto.Hospital
            };

            _context.Medicos.Add(medico);
            await _context.SaveChangesAsync();

            return Ok("Médico criado com sucesso!");
        }

        [HttpPut("{id}/EditarMedico")]
        public async Task<IActionResult> EditarMedico(int id, [FromBody] CriarMedico medicoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var medico = await _context.Medicos.FindAsync(id);
            if (medico == null)
                return NotFound("Médico não encontrado.");

            var especialidade = await _context.Especialidades.FindAsync(medicoDto.EspecialidadeId);
            if (especialidade == null)
                return BadRequest("Especialidade inválida.");

            medico.NumeroOrdemMedicos = medicoDto.NumeroOrdemMedicos;
            medico.NumeroMecanografico = medicoDto.NumeroMecanografico;
            medico.NomeProfissionalSaude = medicoDto.NomeProfissionalSaude;
            medico.EspecialidadeId = medicoDto.EspecialidadeId;
            medico.Hospital = medicoDto.Hospital;

            await _context.SaveChangesAsync();

            return Ok("Médico editado com sucesso!");
        }

        [HttpGet("ProcurarMedico")]
        public async Task<ActionResult<VerMedico>> ProcurarMedico(int idMedico)
        {
            var medico = await _context.Medicos
                .Include(m => m.Especialidade)
                .FirstOrDefaultAsync(m => m.MedicoId == idMedico);

            if (medico == null)
                return NotFound("Médico não foi encontrado");

            var medicoVm = new VerMedico
            {
                NumeroOrdemMedicos = medico.NumeroOrdemMedicos,
                NumeroMecanografico = medico.NumeroMecanografico,
                NomeProfissionalSaude = medico.NomeProfissionalSaude,
                EspecialidadeNome = medico.Especialidade.Nome,
                Hospital = medico.Hospital
            };

            return Ok(medicoVm);
        }
    }
}
