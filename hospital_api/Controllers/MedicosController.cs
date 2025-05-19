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
        private readonly ApplicationDbContext _context;

        public MedicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CriarMedico")]
        public async Task<IActionResult> CriarMedico(CriarMedico medicoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var medico = new Medico
            {
                NumeroOrdemMedicos = medicoDto.NumeroOrdemMedicos,
                NumeroMecanografico = medicoDto.NumeroMecanografico,
                NomeProfissionalSaude = medicoDto.NomeProfissionalSaude,
                Especialidade = medicoDto.Especialidade,
                Hospital = medicoDto.Hospital
            };
            //adicao a base de dados
            _context.Medicos.Add(medico);
            await _context.SaveChangesAsync();

            return Ok("Médico criado com sucesso!");
        }

        [HttpPut("{id}/EditarMedico")]
        public async Task<IActionResult> EditarMedico(int id, [FromBody] CriarMedico medicoDto)
        {
            var medicoExistente = await _context.Medicos.FindAsync(id);
            if (medicoExistente == null)
            {
                return NotFound("Médico não encontrado.");
            }

            medicoExistente.NumeroOrdemMedicos = medicoDto.NumeroOrdemMedicos;
            medicoExistente.NumeroMecanografico = medicoDto.NumeroMecanografico;
            medicoExistente.NomeProfissionalSaude = medicoDto.NomeProfissionalSaude;
            medicoExistente.Especialidade = medicoDto.Especialidade;
            medicoExistente.Hospital = medicoDto.Hospital;

            await _context.SaveChangesAsync();

            return Ok("Médico editado com sucesso!");
        }

        [HttpGet("ProcurarMedico")]
        public async Task<ActionResult<VerMedico>> ProcurarMedico(int idMedico)
        {
            var medico = await _context.Medicos
                .FirstOrDefaultAsync(m => m.MedicoId == idMedico);

            if (medico == null)
            {
                return NotFound("Médico não foi encontrado");
            }

            var medicoVm = new VerMedico
            {
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
