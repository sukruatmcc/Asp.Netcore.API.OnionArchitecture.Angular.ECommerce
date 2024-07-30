using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
  public static class ServiceRegistration
  {
    public static void AddPersistenceServices(this IServiceCollection services)//bunları IoC container eklicez
    {
      services.AddSingleton<IProductService, ProductService>();//herbir service sınıfını IoC containere ekleyebilmem için burdaki extension metodu kullanman gerek.
    }
  }
}
