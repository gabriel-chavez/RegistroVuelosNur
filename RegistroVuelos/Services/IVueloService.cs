using System;
using System.Collections.Generic;

namespace RegistroVuelos.Services
{
    public interface IVueloService
    {
        Guid CrearVuelo(Models.Vuelo vuelo);
        List<Models.Vuelo> Listar();
        
    }
}
