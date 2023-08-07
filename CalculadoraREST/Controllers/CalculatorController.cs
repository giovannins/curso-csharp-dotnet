using Microsoft.AspNetCore.Mvc;

namespace CalculadoraREST.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
    public IActionResult Soma(string primeiroNumero, string segundoNumero)
    {
        if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
        {
            var soma = ConvertToDecimal(primeiroNumero) + ConvertToDecimal(segundoNumero);
            return Ok(soma);
        }
        return BadRequest("Input inválido");
    }

    [HttpGet("menos/{primeiroNumero}/{segundoNumero}")]
    public IActionResult Menos(string primeiroNumero, string segundoNumero)
    {
        if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
        {
            var menos = ConvertToDecimal(primeiroNumero) - ConvertToDecimal(segundoNumero);
            return Ok(menos);
        }
        return BadRequest("Input inválido");
    }

    [HttpGet("mult/{primeiroNumero}/{segundoNumero}")]
    public IActionResult Mult(string primeiroNumero, string segundoNumero)
    {
        if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
        {
            var mult = ConvertToDecimal(primeiroNumero) * ConvertToDecimal(segundoNumero);
            return Ok(mult);
        }
        return BadRequest("Input inválido");
    }

    [HttpGet("divi/{primeiroNumero}/{segundoNumero}")]
    public IActionResult Divi(string primeiroNumero, string segundoNumero)
    {
        if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
        {
            var divi = ConvertToDecimal(primeiroNumero) / ConvertToDecimal(segundoNumero);
            return Ok(divi);
        }
        return BadRequest("Input inválido");
    }

    [HttpGet("raiz-quadrada/{numero}")]
    public IActionResult Raiz(string numero)
    {
        if (IsNumeric(numero))
        {
            var raiz = Math.Sqrt(ConvertToDouble(numero));
            return Ok(raiz);
        }
        return BadRequest("Input inválido");
    }

     [HttpGet("potencia/{numero}/{potencia}")]
    public IActionResult Potencia(string numero, string potencia)
    {
        if (IsNumeric(numero) && IsNumeric(potencia))
        {
            var pow = Math.Pow(ConvertToDouble(numero), ConvertToDouble(potencia));
            return Ok(pow);
        }
        return BadRequest("Input inválido");
    }

    private static double ConvertToDouble(string numero)
    {
        if (double.TryParse(numero, out var result)){
            return result;
        }
        return 0;
    }

    private static decimal ConvertToDecimal(string strNumber)
    {
        if (decimal.TryParse(strNumber, out decimal decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }

    private static bool IsNumeric(string strNumber)
    {
        bool IsNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out _);
        return IsNumber;
    }
}
