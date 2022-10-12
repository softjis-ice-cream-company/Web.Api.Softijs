﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Softijs.Services;

namespace Web.Api.Softijs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IServicioCategoria servicio;
        public CategoriasController(IServicioCategoria _servicio)
        {
            this.servicio = _servicio;
        }

        [HttpGet]
        [Route("GetCategorias")]

        public async Task<ActionResult> GetCategorias()
        {
            return Ok(this.servicio.GetCategorias());
        }
    }
}