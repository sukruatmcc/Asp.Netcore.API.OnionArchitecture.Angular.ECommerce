using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
  public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbContext>
  {
    public ECommerceAPIDbContext CreateDbContext(string[] args)
    {
      DbContextOptionsBuilder<ECommerceAPIDbContext> dbContextOptionsBuilder = new();//termianl üzerinden migration oluşturmak için yapılması gerekli
      dbContextOptionsBuilder.UseSqlite(Configuration.ConnectionString);
      return new ECommerceAPIDbContext(dbContextOptionsBuilder.Options);
    }
  }
}
