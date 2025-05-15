using hospital_api.DB;
using hospital_api.Model;
using hospital_api.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace hospital_api.Controllers
{
    // Isto é o controller dos pacientes
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private static int _proximoId = 1;
        private static readonly List<Paciente> _pacientes = new();
        private readonly ApplicationDbContext _context;
        public PacientesController(ApplicationDbContext context)
        {
            _context = context;
        }
        //para criar paciente

        [HttpPost]
        public IActionResult CriarPaciente([FromBody] CriarPaciente pacienteDto)
        {
            //Verifica se a data de nascimento é válida
            if (pacienteDto.DataNascimento > DateTime.Today)
            {
                return BadRequest("A data de nascimento tem de ser inferior à data atual");
            }

            var paciente = new Paciente
            {
                Id = _proximoId++,
                Nome = pacienteDto.Nome,
                DataNascimento = pacienteDto.DataNascimento,
                NIF = pacienteDto.NIF,
                Morada = pacienteDto.Morada
            };

            _pacientes.Add(paciente);

            return Ok("Paciente criado com sucesso!");
        }

        [HttpPut("{id}")]
        public ActionResult <EditarPaciente> EditarPaciente(int id, [FromBody] CriarPaciente pacienteDto)
        {
            // Verifica se a data de nascimento é válida
            if (pacienteDto.DataNascimento > DateTime.Today)
            {
                return BadRequest("A data de nascimento tem de ser inferior à data atual");
            }

            //Procura na base de dados
            var pacienteExistente = _context.Pacientes.Find(id);
            if (pacienteExistente == null)
            {
                return NotFound("Paciente não encontrado.");
            }

            // Atualiza os dados do paciente
            pacienteExistente.Nome = pacienteDto.Nome;
            pacienteExistente.DataNascimento = pacienteDto.DataNascimento;
            pacienteExistente.NIF = pacienteDto.NIF;
            pacienteExistente.Morada = pacienteDto.Morada;

            // Guarda as alterações
            _context.SaveChanges();

            return Ok("Paciente editado com sucesso!");
        }
        
        [HttpGet("{id}")]
        public ActionResult <VerPaciente> ProcurarPaciente(int id)
        {
            var paciente = _pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound("Paciente não foi encontrado");
            }

            var pacienteVm = new VerPaciente
            {
                Id = paciente.Id,
                Nome = paciente.Nome,
                DataNascimento = paciente.DataNascimento,
                Age = paciente.CalcularIdade(),
                NIF = paciente.NIF,
                Morada = paciente.Morada
            };

            return Ok(pacienteVm);
        }
    }
}