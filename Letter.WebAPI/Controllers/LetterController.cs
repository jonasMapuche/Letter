using Letter.Models;
using Letter.WebAPI.Models;
using Letter.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Letter.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LetterController : ControllerBase
    {
        public static readonly LetterService _lettersService = new LetterService();
        public static readonly VersionService _version = new VersionService();

        [HttpGet("")]
        public async Task<ActionResult> Get()
        {
            await Task.Delay(500);
            return Ok("Expression building program based on lessons!");
        }

        [HttpGet("all")]
        public async Task<List<Aula>> GetAll()
        {
            return await _lettersService.GetAsync();
        }

        [HttpPost("add")]
        public async Task<IActionResult> Post(Aula aula)
        {
            await _lettersService.CreateAsync(aula);
            return CreatedAtAction(nameof(Get), new { id = aula.Id }, aula);
        }

        [HttpGet("version")]
        public async Task<GitUser> GetVersion()
        {
            return await _version.GetVersionAsync();
        }
    }
}
