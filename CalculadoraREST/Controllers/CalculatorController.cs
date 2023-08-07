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
