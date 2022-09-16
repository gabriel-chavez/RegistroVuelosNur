using Cross.Event.Src.Bus;
using MediatR;
using RegistroVuelos.Messages.Commands;
using RegistroVuelos.Messages.Events;
using System.Threading;
using System.Threading.Tasks;

namespace RegistroVuelos.Messages.CommandHandlers
{
    public class VueloCommandHandler : IRequestHandler<VueloCreateCommand, bool>
    {
        private readonly IEventBus _bus;

        public VueloCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(VueloCreateCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new VueloCreatedEvent(request.IdVuelo,request.Origen,request.Destino,request.HoraPartida,request.HoraLlegada,request.IdAeronave,request.CantidadAsientos), "vuelo.VueloCreatedEvent.pago.crearVuelo"); 
            return Task.FromResult(true);
 
        }
    }
}
