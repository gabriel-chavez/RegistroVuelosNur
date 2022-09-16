using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroVuelos.Models
{
    public class Vuelo
    {
        [Key]
        public Guid IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public TimeSpan HoraPartida { get; set; }
        public TimeSpan HoraLlegada { get; set; }     
        public Guid IdAeronave { get; set; }
        public int CantidadAsientos { get; set; }

        public Vuelo()
        {
            IdVuelo = Guid.NewGuid();
            CantidadAsientos = 20;
           // Tripulacion = new List<Tripulacion>();
        }

    }
}
