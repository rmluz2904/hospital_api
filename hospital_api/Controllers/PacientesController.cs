using hospital_api.DB;
using hospital_api.Model;
using hospital_api.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PacientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CriarPaciente")]
        public async Task<IActionResult> CriarPaciente([FromBody] CriarPaciente pacienteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var paciente = new Paciente
            {
                Nome = pacienteDto.Nome,
                DataNascimento = pacienteDto.DataNascimento,
                NIF = pacienteDto.NIF,
                Morada = pacienteDto.Morada
            };

            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();

            return Ok("Paciente criado com sucesso!");
        }

        [HttpPut("{id}/EditarPaciente")]
        public async Task<IActionResult> EditarPaciente(int id, [FromBody] CriarPaciente pacienteDto)
        {
            var pacienteExistente = await _context.Pacientes.FindAsync(id);
            if (pacienteExistente == null)
            {
                return NotFound("Paciente não encontrado.");
            }

            pacienteExistente.Nome = pacienteDto.Nome;
            pacienteExistente.DataNascimento = pacienteDto.DataNascimento;
            pacienteExistente.NIF = pacienteDto.NIF;
            pacienteExistente.Morada = pacienteDto.Morada;

            await _context.SaveChangesAsync();

            return Ok("Paciente editado com sucesso!");
        }

        [HttpGet("ProcurarPaciente")]
        public async Task<ActionResult<VerPaciente>> ProcurarPaciente(int id)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(p => p.PacienteId == id);

            if (paciente == null)
            {
                return NotFound("Paciente não foi encontrado");
            }

            var pacienteVm = new VerPaciente
            {
                Nome = paciente.Nome,
                DataNascimento = paciente.DataNascimento,
                Age = paciente.CalcularIdade(),
                NIF = paciente.NIF,
                Morada = paciente.Morada
            };

            return Ok(pacienteVm);
        }

        [HttpGet("ListarPacientes")]
        public async Task<ActionResult<List<VerPaciente>>> ListarTodos()
        {
            var lista = await _context.Pacientes
                .Select(p => new VerPaciente
                {
                    Nome = p.Nome,
                    DataNascimento = p.DataNascimento,
                    Age = p.CalcularIdade(),
                    NIF = p.NIF,
                    Morada = p.Morada
                })
                .ToListAsync();

            return Ok(lista);
        }
    }
}