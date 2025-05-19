using hospital_api.DB;
using hospital_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital_api.Controllers
{
    public class EspecialidadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        [HttpGet("Especialidades")]
        public async Task<ActionResult<List<Especialidade>>> ListarEspecialidades()
        {
            var especialidades = await _context.Especialidades.ToListAsync();
            return Ok(especialidades);
        }

    }
}
