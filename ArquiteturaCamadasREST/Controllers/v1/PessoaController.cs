using ArquiteturaCamadasREST.Models;
using ArquiteturaCamadasREST.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaCamadasREST.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PessoaController : ControllerBase
{

    private readonly IPessoaService _pessoaService;

    public PessoaController(IPessoaService pessoaService)
    {
        _pessoaService = pessoaService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_pessoaService.FindAll());
    }

    [HttpPost]
    public IActionResult PostCreate([FromBody] Pessoa pessoa)
    {
        if (pessoa == null)
        {
            return BadRequest("Arquivo nulo ou mal formatado");
        }
        return Ok(_pessoaService.Create(pessoa));
    }
}