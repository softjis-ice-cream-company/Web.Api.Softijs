﻿using Web.Api.Softijs.Models;

namespace Web.Api.Softijs.Commands.Comunes
{
    public class ComboBoxItemDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public static implicit operator ComboBoxItemDto(EstadosPedido entity)
        {
            return new ComboBoxItemDto
            {
                Id = entity.IdEstadoPedido,
                Codigo = entity.Codigo,
                Descripcion = entity.Descripcion
            };
        }

        public static implicit operator ComboBoxItemDto(FormasPago entity)
        {
            return new ComboBoxItemDto
            {
                Id = entity.IdFormaPago,
                Codigo = entity.Codigo,
                Descripcion = entity.Descripcion
            };
        }

        public static implicit operator ComboBoxItemDto(Cliente entity)
        {
            return new ComboBoxItemDto
            {
                Id = entity.IdCliente,
                Codigo = $"{entity.Dni} - {entity.Nombre}, {entity.Apellido}",
                Descripcion = $"{entity.Dni} - {entity.Nombre}, {entity.Apellido}"
            };
        }

        public static implicit operator ComboBoxItemDto(Usuario entity)
        {
            return new ComboBoxItemDto
            {
                Id = entity.IdUsuario,
                Codigo = $"{entity.Legajo} - {entity.Nombre}, {entity.Apellido}",
                Descripcion = $"{entity.Legajo} - {entity.Nombre}, {entity.Apellido}"
            };
        }

        public static implicit operator ComboBoxItemDto(Producto entity)
        {
            return new ComboBoxItemDto
            {
                Id = entity.NroProducto,
                Codigo = $"{entity.Codigo} - {entity.Nombre}",
                Descripcion = $"{entity.Codigo} - {entity.Nombre}"
            };
        }

        public static implicit operator ComboBoxItemDto(Pedido entity)
        {
            return new ComboBoxItemDto
            {
                Id = entity.NroPedido,
                Codigo = entity.NroPedido.ToString(),
                Descripcion = entity.NroPedido.ToString()
            };
        }
    }
}