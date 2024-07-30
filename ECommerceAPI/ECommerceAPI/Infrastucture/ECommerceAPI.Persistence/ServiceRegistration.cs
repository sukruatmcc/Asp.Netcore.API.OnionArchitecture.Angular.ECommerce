using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
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
      services.AddDbContext<ECommerceAPIDbContext>(options => options.UseSqlite(Configuration.ConnectionString));
    }
  }
}
