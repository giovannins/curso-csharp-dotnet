using MetodosREST.Models;
using MetodosREST.Services;
using Microsoft.AspNetCore.Mvc;

namespace MetodosREST.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    private readonly ILogger<PessoaController> _logger;
    private readonly IPessoaService _pessoaService;
    private string dateTime;

    public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoaService)
    {
        _logger = logger;
        _pessoaService = pessoaService;
        dateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation($"GET FindAll Pessoas feito em: {dateTime}");
        return Ok(_pessoaService.FindAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetID(long id)
    {
        Pessoa pessoa = _pessoaService.FindById(id);
        if (pessoa == null)
        {
            _logger.LogWarning($"GET GetID Pessoas feito em {dateTime}. Não foi encontrado a Pessoa com id: {id}");
            return NotFound();
        }
        _logger.LogInformation($"GET GetID Pessoas feito em {dateTime}. Foi encontrado a Pessoa com id: {id}");
        return Ok(pessoa);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Pessoa pessoa)
    {
        if (pessoa == null)
        {
            _logger.LogWarning($"POST Create Pessoas feito em {dateTime}. Não foi possivel incluir: {pessoa.Id} {pessoa.Nome}");
            return BadRequest("");
        }
        _logger.LogInformation($"POST Create Pessoas feito em {dateTime}. Foi criado com sucesso: {pessoa.Id} {pessoa.Nome}");
        return Ok(_pessoaService.Create(pessoa));
    }

    [HttpPut]
    public IActionResult Update([FromBody] Pessoa pessoa)
    {
        if (pessoa == null)
        {
            _logger.LogWarning($"PUT Update Pessoas feito em {dateTime}. Não foi possivel atualizar: {pessoa.Id} {pessoa.Nome}");
            return BadRequest("");
        }
        _logger.LogInformation($"PUT Update Pessoas feito em {dateTime}. Foi possivel atualizar: {pessoa.Id} {pessoa.Nome}");
        return Ok(_pessoaService.Update(pessoa));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _logger.LogWarning($"DELETE Delete Pessoas feito em {dateTime}. Foi deletado pessoa: {id}");
        _pessoaService.Delete(id);
        return NoContent();
    }
}
