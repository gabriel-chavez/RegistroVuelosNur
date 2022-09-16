using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroVuelos.DTOs
{
    public class VueloDto
    {
   
        public Guid IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string HoraPartida { get; set; }
        public string HoraLlegada { get; set; }
        public int CantidadAsientos { get; set; }
        public List<TripulacionDto> Tripulacion { get; set; }        
        public Guid IdAeronave { get; set; }
       

    }
   
}
