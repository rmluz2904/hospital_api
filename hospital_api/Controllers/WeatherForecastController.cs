using Microsoft.AspNetCore.Mvc;

namespace hospital_api.Controllers
{
    // Isto é o controller dos pacientes
    [ApiController]
    [Route("[controller]")]
    public class PacientesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PacientesController> _logger;

        public PacientesController(ILogger<PacientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Paciente")]
        public IEnumerable<paciente> Get()
        {
           
            
        }
    }
}
