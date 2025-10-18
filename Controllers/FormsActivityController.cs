using System.Threading.Tasks;
using HubCollege.Data;
using HubCollege.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HubCollege.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormsActivityController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public FormsActivityController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // ==============================
        // GET: api/formsactivity
        // ==============================
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var activities = await _appDbContext.FormsActivities.ToListAsync();
            return Ok(activities);
        }

        // ==============================
        // GET: api/formsactivity/{id}
        // ==============================
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var activity = await _appDbContext.FormsActivities.FindAsync(id);
            if (activity == null)
                return NotFound();
            return Ok(activity);
        }

        // ==============================
        // POST: api/formsactivity
        // ==============================
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FormsActivity model)
        {
            if (model == null)
                return BadRequest("The data must not be null");

            // adiciona o registro
            await _appDbContext.FormsActivities.AddAsync(model);

            // salva no banco
            await _appDbContext.SaveChangesAsync();

            // retorna 201 Created
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }
    }
}
