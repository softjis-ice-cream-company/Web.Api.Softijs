﻿using Web.Api.Softijs.Models;

namespace Web.Api.Softijs.Services
{
    public interface IServicioMarcas
    {
        Task<List<Marca>> GetMarcas();
    }
}
