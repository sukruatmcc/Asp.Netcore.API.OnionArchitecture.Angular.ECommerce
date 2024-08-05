using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Repositories;

namespace ECommerceAPI.Persistence
{
  public static class ServiceRegistration
  {
    public static void AddPersistenceServices(this IServiceCollection services)//bunları IoC container eklicez//ıoc containerlerımıza servislerimizi ekledik
    {
      services.AddDbContext<ECommerceAPIDbContext>(options => options.UseSqlite(Configuration.ConnectionString), ServiceLifetime.Singleton);
      services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();//default olarak scoped eklediği için scoped ekledik;
      services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
      services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
      services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
      services.AddSingleton<IProductReadRepository, ProductReadRepository>();
      services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
    }
  }
}
