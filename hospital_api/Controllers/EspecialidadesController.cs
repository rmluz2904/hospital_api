using hospital_api.DB;
using hospital_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.Controllers
{
    [ApiController]
    public class EspecialidadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EspecialidadesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("Especialidades")]
        public async Task<ActionResult<List<Especialidade>>> ListarEspecialidades()
        {
            var especialidades = await _context.Especialidades
                .OrderBy(e => e.Nome)
                .ToListAsync();

            return Ok(especialidades);

        }

    }
}
