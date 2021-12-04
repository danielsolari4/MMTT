using mmTt.Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmTt.Aplication.Producto.Interface
{
    interface IProductoApplication
    {
        void GetProductById(int Id);
        void Add(ProductoDto producto);
        void Delete(int Id);
    }
}
