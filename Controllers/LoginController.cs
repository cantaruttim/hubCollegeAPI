using HubCollege.Data;
using HubCollege.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HubCollege.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public LoginController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var login = await _appDbContext.Logins.ToListAsync();
            return Ok(login);
        }

        [HttpGet("id/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var login = await _appDbContext.Logins.FindAsync(id);
            if (login == null)
                return NotFound();
            return Ok(login);
        }

        [HttpGet("registration/{registrationNumber}")]
        public async Task<IActionResult> GetByRegistrationNumber(string registrationNumber)
        {
            var login = await _appDbContext.Logins
                .FirstOrDefaultAsync(a => a.RegistrationNumber == registrationNumber);

            if (login == null)
                return NotFound();

            return StatusCode(200, login);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Login model)
        {
            if (model == null)
                return BadRequest("The data must not be null");

            // add data
            await _appDbContext.Logins.AddAsync(model);

            // commit data on db
            await _appDbContext.SaveChangesAsync();

            // return 201 Created
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdtadeForms(int id, [FromBody] Login updatedLogin)
        {

            var login = await _appDbContext.Logins.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }

            _appDbContext.Entry(login).CurrentValues.SetValues(updatedLogin);
            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, login);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteLogin(int id)
        {

            var login = await _appDbContext.Logins.FindAsync(id);
            if (login == null)
            {
                return NotFound("Login Not Found!");
            }

            _appDbContext.Logins.Remove(login);
            await _appDbContext.SaveChangesAsync();

            return Ok("Login deleted successfully!");
        }



    }
    
}