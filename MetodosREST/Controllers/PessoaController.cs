using MetodosREST.Models;
using MetodosREST.Services;
using Microsoft.AspNetCore.Mvc;

namespace MetodosREST.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    private readonly ILogger<PessoaController> _logger;
    private IPessoaService _pessoaService;

    public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoaService)
    {
        _logger = logger;
        _pessoaService = pessoaService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_pessoaService.FindAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetID(long id)
    {
        Pessoa pessoa = _pessoaService.FindById(id);
        if (pessoa == null)
        {
            return NotFound();
        }
        return Ok(pessoa);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Pessoa pessoa)
    {
        if (pessoa == null)
        {
            return BadRequest("");
        }
        return Ok(_pessoaService.Create(pessoa));
    }

    [HttpPut]
    public IActionResult Update([FromBody] Pessoa pessoa)
    {
        if (pessoa == null)
        {
            return BadRequest("");
        }
        return Ok(_pessoaService.Update(pessoa));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _pessoaService.Delete(id);
        return NoContent();
    }
}
