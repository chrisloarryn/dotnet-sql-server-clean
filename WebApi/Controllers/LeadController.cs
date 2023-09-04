using dotnet_backend.Domain.Entities;
using dotnet_backend.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly ILeadRepository _leadRepository;

        public LeadController(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var leads = await _leadRepository.GetAllAsync();
            return Ok(leads);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var lead = await _leadRepository.GetByIdAsync(id);
            if (lead == null)
            {
                return NotFound();
            }
            return Ok(lead);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Lead lead)
        {
            await _leadRepository.AddAsync(lead);
            return CreatedAtAction(nameof(GetById), new { id = lead.Id }, lead);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Lead lead)
        {
            if (id != lead.Id)
            {
                return BadRequest();
            }
            await _leadRepository.UpdateAsync(lead);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _leadRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}