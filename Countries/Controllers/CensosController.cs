using Countries.Models.Name;
using Countries.Models.Tarea_02;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Countries.Controllers;
[ApiController]
[Route("[controller]")]
public class CensosController : ControllerBase
{
    private readonly string _rutaCenso;
    public CensosController()
    {
        _rutaCenso = @"E:\repos\JavaScript\censo2023.json";
    }

    [HttpGet("Tarea-1")]
    public async Task<ActionResult<Censo>> GetCenso()
    {
        using(var sr = new StreamReader(_rutaCenso))
        {
            string jsonString = sr.ReadToEnd();

            var censoResultado = JsonConvert.DeserializeObject<Censo>(jsonString);

            return censoResultado;
        }
    }

    [HttpGet("Tarea-2")]
    public async Task<ActionResult<Languages02>> DetailLanguages()
    {
        using (var sr = new StreamReader(_rutaCenso))
        {
            string jsonString = sr.ReadToEnd();

            var listarLanguagues = JsonConvert.DeserializeObject<Languages02>(jsonString);

            return listarLanguagues;
        }
    }
}
