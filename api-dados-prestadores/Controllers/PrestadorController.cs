using api_dados_prestadores.Data;
using api_dados_prestadores.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_dados_prestadores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrestadorController : ControllerBase
    {

        PrestadorContext _context;
        public PrestadorController(PrestadorContext context) { 
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<Results<NotFound,Ok<Prestador>>> GetPrestadorById(int id)
        {
            Prestador prestador = await _context.Prestadores.Include(p=>p.Enderecos).AsNoTracking().FirstOrDefaultAsync(p=>p.NumeroContrato == id);

            if (prestador == null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Ok<Prestador>(prestador);

        }
    }
}
