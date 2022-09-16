using Cross.Event.Src.Bus;
using Microsoft.AspNetCore.Mvc;
using RegistroVuelos.DTOs;
using RegistroVuelos.Messages.Commands;
using RegistroVuelos.Services;
using System;
using System.Linq;

namespace RegistroVuelos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloController : ControllerBase
    {
        private readonly IVueloService _vueloService;
        private readonly IEventBus _bus;

        public VueloController(IVueloService vueloService, IEventBus bus)
        {
            _vueloService = vueloService;
            _bus = bus;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var query = from result in _vueloService.Listar()
                        select new VueloDto()
                        {
                            IdVuelo = result.IdVuelo,
                            Origen = result.Origen,
                            Destino = result.Destino,
                            HoraPartida = result.HoraPartida.ToString(),
                            HoraLlegada = result.HoraLlegada.ToString(),
                            IdAeronave = result.IdAeronave
                        };

            return Ok(query);
        }
        [HttpPost]
        public IActionResult Registrar([FromBody] VueloDto request)
        {
            Models.Vuelo vuelo = new Models.Vuelo()
            {
                Origen = request.Origen,
                Destino = request.Destino,
                HoraPartida = TimeSpan.Parse(request.HoraPartida),
                HoraLlegada = TimeSpan.Parse(request.HoraLlegada),
                IdAeronave = request.IdAeronave,
            };
            _vueloService.CrearVuelo(vuelo);
            request.IdVuelo = vuelo.IdVuelo;
            var vueloCreateCommand = new VueloCreateCommand(
                idVuelo: vuelo.IdVuelo,
                origen: vuelo.Origen,
                destino: vuelo.Destino,
                horaPartida:vuelo.HoraPartida,
                horaLlegada:vuelo.HoraLlegada,
                idAeronave:vuelo.IdAeronave,
                cantidadAsientos:vuelo.CantidadAsientos
                );
            _bus.SendCommand(vueloCreateCommand);
            return Ok(request);
        }
    }
}
