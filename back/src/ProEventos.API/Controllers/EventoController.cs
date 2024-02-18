using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{


    private readonly ILogger<EventoController> _logger;
    
       
        private readonly DataContext _context;

    public EventoController(DataContext context){
        
        this._context = context;     

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetByID(int id)
    {
        return _context.Eventos.FirstOrDefault(
            evento => evento.EventoId == id);
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
