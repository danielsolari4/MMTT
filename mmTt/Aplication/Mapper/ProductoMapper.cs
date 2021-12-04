using mmTt.Aplication.Dtos;
using mmTt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmTt.Aplication.Mapper
{
    public static class ProductoMapper
    {


        public static Producto ToEntity(ProductoDto productoDto)
        {
            return new Producto()
            {
                Title = productoDto.Title,
                Description = productoDto.Description,
                MediaUrl = productoDto.MediaUrl,
                CategoryName = productoDto.CategoryName,
                PublicationDate = productoDto.PublicationDate,
                Author = productoDto.Author

            };
        }

        public static ProductoDto ToDto(Producto producto)
        {
            return new ProductoDto()
            {
                Title = producto.Title,
                Description = producto.Description,
                MediaUrl = producto.MediaUrl,
                CategoryName = producto.CategoryName,
                PublicationDate = producto.PublicationDate,
                Author = producto.Author
            };
        }
    }
}