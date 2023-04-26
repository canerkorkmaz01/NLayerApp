using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repository
{
    public interface IProductRepository:IGenericRespository<Product>
    {
        Task<List<Product>> GetProductsWitCategory();
    }
}
