using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();//bu bir soyut yapılanmadır.Çünkü application katmanında yer alır//cuncrit -> somut yapılanmadır ama bunun somutununa ihtiyacımız var
    }
}
