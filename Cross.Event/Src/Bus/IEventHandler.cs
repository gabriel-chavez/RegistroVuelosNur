using Cross.Event.Src.Events;
using System.Threading.Tasks;

namespace Cross.Event.Src.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
         where TEvent : Cross.Event.Src.Events.Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
