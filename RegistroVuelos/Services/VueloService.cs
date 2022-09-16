using Microsoft.EntityFrameworkCore;
using RegistroVuelos.Models;
using RegistroVuelos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistroVuelos.Services
{
    public class VueloService : IVueloService
    {
        private readonly ContextDatabase _contextDatabase;

        public VueloService(ContextDatabase contextDatabase)
        {
            _contextDatabase = contextDatabase;
        }

        public Guid CrearVuelo(Vuelo vuelo)
        {
            _contextDatabase.Vuelo.Add(vuelo);
            _contextDatabase.SaveChanges();
            return vuelo.IdVuelo;
        }

        public List<Vuelo> Listar()
        {
            return _contextDatabase.Vuelo.ToList();
        }
    }
}
