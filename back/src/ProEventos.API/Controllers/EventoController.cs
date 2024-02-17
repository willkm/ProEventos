using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{


    private readonly ILogger<EventoController> _logger;
    public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular e .Net Core",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.ToString("dd/mm/yyyy")
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular e .Net Core",
                Local = "Recife",
                Lote = "3º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
            }
    };



    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetByID(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Salvo com Sucesso!";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Salvo com Sucesso! ID enviado foi : {id}"  ;
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"deletado com Sucesso! ID enviado foi : {id}"  ;
    }
}
