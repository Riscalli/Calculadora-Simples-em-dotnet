// Controllers/CalculadoraController.cs
// Este é o controlador que contém a lógica da sua calculadora.

using Microsoft.AspNetCore.Mvc;

// Define a rota base para este controlador. Todas as ações abaixo
// serão acessadas com a URL /api/calculadora.
[ApiController]
[Route("api/[controller]")]
public class CalculadoraController : ControllerBase
{
    // Endpoint para adição. Exemplo de uso: GET /api/calculadora/adicao/5/3
    [HttpGet("adicao/{num1}/{num2}")]
    public IActionResult Adicao(double num1, double num2)
    {
        double resultado = num1 + num2;
        // Retorna um status de sucesso (200 OK) com o resultado.
        return Ok(resultado);
    }

    // Endpoint para subtração. Exemplo de uso: GET /api/calculadora/subtracao/10/4
    [HttpGet("subtracao/{num1}/{num2}")]
    public IActionResult Subtracao(double num1, double num2)
    {
        double resultado = num1 - num2;
        return Ok(resultado);
    }

    // Endpoint para multiplicação. Exemplo de uso: GET /api/calculadora/multiplicacao/5/5
    [HttpGet("multiplicacao/{num1}/{num2}")]
    public IActionResult Multiplicacao(double num1, double num2)
    {
        double resultado = num1 * num2;
        return Ok(resultado);
    }

    // Endpoint para divisão. Exemplo de uso: GET /api/calculadora/divisao/10/2
    [HttpGet("divisao/{num1}/{num2}")]
    public IActionResult Divisao(double num1, double num2)
    {
        // Garante que a divisão por zero não cause um erro de servidor.
        if (num2 == 0)
        {
            // Retorna um erro de Requisição Inválida (400 Bad Request)
            // com uma mensagem amigável para o usuário.
            return BadRequest("Erro: Divisão por zero não é permitida.");
        }
        double resultado = num1 / num2;
        return Ok(resultado);
    }
}