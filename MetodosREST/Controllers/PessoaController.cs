using Microsoft.AspNetCore.Mvc;

namespace MetodosREST.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    private readonly ILogger<PessoaController> _logger;

    public PessoaController(ILogger<PessoaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return NoContent();
    }
}
