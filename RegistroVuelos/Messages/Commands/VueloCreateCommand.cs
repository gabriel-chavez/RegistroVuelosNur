using Cross.Event.Src.Commands;
using System;

namespace RegistroVuelos.Messages.Commands
{
    public class VueloCreateCommand:Command
    {
        public VueloCreateCommand(Guid idVuelo, string origen, string destino, TimeSpan horaPartida, TimeSpan horaLlegada, Guid idAeronave, int cantidadAsientos)
        {
            IdVuelo = idVuelo;
            Origen = origen;
            Destino = destino;
            HoraPartida = horaPartida;
            HoraLlegada = horaLlegada;
            IdAeronave = idAeronave;
            CantidadAsientos= cantidadAsientos;
        }

        public Guid IdVuelo { get; protected set; }
        public string Origen { get; protected set; }
        public string Destino { get; protected set; }
        public TimeSpan HoraPartida { get; protected set; }
        public TimeSpan HoraLlegada { get; protected set; }
        public Guid IdAeronave { get; protected set; }
        public int CantidadAsientos { get; protected set; }
    }
}
