using Cross.Event.Src.Events;
using System;

namespace RegistroVuelos.Messages.Events
{
    public class VueloCreatedEvent:Event
    {
        public VueloCreatedEvent(Guid idVuelo, string origen, string destino, TimeSpan horaPartida, TimeSpan horaLlegada, Guid idAeronave, int cantidadAsientos)
        {
            IdVuelo = idVuelo;
            Origen = origen;
            Destino = destino;
            HoraPartida = horaPartida;
            HoraLlegada = horaLlegada;
            IdAeronave = idAeronave;
            CantidadAsientos = cantidadAsientos;
        }

        public Guid IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public TimeSpan HoraPartida { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public Guid IdAeronave { get; set; }
        public int CantidadAsientos { get;  set; }
    }
}
