using RegistroVuelos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistroVuelos.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContextDatabase context)
        {
            context.Database.EnsureCreated();

            if (context.Vuelo.Any())
            {
                return;
            }
            var vuelo = new Models.Vuelo[]
            {
                new Models.Vuelo{ Origen="La Paz", Destino="Santa Cruz",HoraPartida=new TimeSpan(5, 0, 0), HoraLlegada=new TimeSpan(11,0,0),IdAeronave=Guid.NewGuid()},
                new Models.Vuelo{ Origen="Cochabamba", Destino="Santa Cruz",HoraPartida=new TimeSpan(8, 0, 0), HoraLlegada=new TimeSpan(11,0,0)
                ,IdAeronave=Guid.NewGuid()},
            };
            foreach (Models.Vuelo s in vuelo)
            {
                context.Vuelo.Add(s);
            }

            /****/
            if (context.Vuelo.Any())
            {
                return;
            }
            var tripulantes = new Models.Tripulacion[]
            {
                new Models.Tripulacion{ IdTripulante=Guid.NewGuid(), IdVuelo=vuelo[0].IdVuelo},
                new Models.Tripulacion{ IdTripulante=Guid.NewGuid(), IdVuelo=vuelo[0].IdVuelo},
                new Models.Tripulacion{ IdTripulante=Guid.NewGuid(), IdVuelo=vuelo[1].IdVuelo},
                new Models.Tripulacion{ IdTripulante=Guid.NewGuid(), IdVuelo=vuelo[1].IdVuelo}

            };
            foreach (Models.Tripulacion s in tripulantes)
            {
                context.Tripulacion.Add(s);
            }
            context.SaveChanges();

        }
    }
}
