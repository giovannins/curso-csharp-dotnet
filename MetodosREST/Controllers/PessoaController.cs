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
        return NoContent();
    }
}
