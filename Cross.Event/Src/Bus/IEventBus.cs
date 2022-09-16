using Cross.Event.Src.Commands;
using System.Threading.Tasks;

namespace Cross.Event.Src.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event,string nombreEvento) where T : Cross.Event.Src.Events.Event;

        void Subscribe<T, TH>()
            where T : Cross.Event.Src.Events.Event
            where TH : IEventHandler<T>;
    }
}
