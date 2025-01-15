using Microsoft.AspNetCore.Mvc;

namespace Vendinhas.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AugustoCesarController : ControllerBase
{
 
 
    [HttpGet(Name = "Api/Get/{nome}")]
    public string Get(string nome)
    {
        return $"Olá {nome ?? "Anônimo(a)"}!";
    }
}
class Mensagem
{
    public string Saudacao { get; set; }
    public string Horario { get; init; } = $"{DateTime.Now:HH:mm:ss}";
}