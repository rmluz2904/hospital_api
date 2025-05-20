using hospital_api.DB;
using hospital_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("MarcarConsulta")]
        public async Task<IActionResult> MarcarConsulta([FromBody]Consulta consultaDto)
        {
            if (consultaDto == null || consultaDto.PacienteId == 0 || consultaDto.MedicoId == 0 || consultaDto.DataHora == DateTime.MinValue)
            {
                return BadRequest("Dados inválidos.");
            }
            // Verifica se o médico já tem uma consulta agendada para esse horário
            var consultaExistenteMedico = await _context.Consultas
                .Where(c => c.MedicoId == consultaDto.MedicoId && c.DataHora == consultaDto.DataHora)
                .FirstOrDefaultAsync();

            if (consultaExistenteMedico != null)
            {
                return BadRequest("O médico já tem uma consulta agendada para esse horário.");
            }

            // Verifica se o paciente já tem uma consulta agendada para esse horário
            var consultaExistentePaciente = await _context.Consultas
                .Where(c => c.PacienteId == consultaDto.PacienteId && c.DataHora == consultaDto.DataHora)
                .FirstOrDefaultAsync();

            if (consultaExistentePaciente != null)
            {
                return BadRequest("O paciente já tem uma consulta agendada para esse horário.");
            }

            // Criação da consulta
            var consulta = new Consulta
            {
                PacienteId = consultaDto.PacienteId,
                MedicoId = consultaDto.MedicoId,
                DataHora = consultaDto.DataHora,
                Status = "Agendada",
                Observacao = consultaDto.Observacao
            };

            _context.Consultas.Add(consulta);
            await _context.SaveChangesAsync();

            return Ok(consulta);
        }
    }
}
