using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroVuelos.Models
{
    public class Tripulacion
    {
        [Key]
        public int Id { get; set; }
        public Guid IdTripulante { get; set; }
        [ForeignKey("Vuelo")]
        public Guid IdVuelo { get; set; }
        
    }
}
