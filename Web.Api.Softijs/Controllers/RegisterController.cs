﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Web.Api.Softijs.Commands;
using Web.Api.Softijs.Models;
using Web.Api.Softijs.Results;
using Web.Api.Softijs.Services;
using System.Security.Cryptography;

namespace Web.Api.Softijs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        private readonly IServicioRegister servicio;

        public RegisterController(IServicioRegister _servicio)
        {
            this.servicio = _servicio;
        }

        [HttpPost]
        [Route("PostRegister")]

        public async Task<ActionResult<ResultadoBase>> PostRegister([FromBody] ComandoRegister comando)
        {
            Usuario r = new Usuario();
            byte[] ePass = GetHash(comando.HashContrasenia);

            r.Nombre = comando.Nombre;
            r.Email = comando.Email;
            r.IdTipoUsuario = 1;
            r.Activo = false;
            r.HashContrasenia = ePass;
            r.CreadoPor = comando.CreadoPor;
            r.ModificadoPor = comando.ModificadoPor;
            r.FechaCreacion = comando.FechaCreacion;
            r.FechaModificacion = comando.FechaModificacion;


            return Ok(this.servicio.PostRegister(r));
        }

        private byte[] GetHash(string key)
        {
            var bytes = Encoding.UTF8.GetBytes(key);
            return new SHA256Managed().ComputeHash(bytes);
        }









    }
}
