using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
  public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository //ReadRepository<Customer> bu sayede bu repositorynin içinde ne kadar method varsa hepsi uygulatılmış olucaktır.
  {
    public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)//read reposiroty paramtere istediğinde bunu göndermek zorundasın.
    {
    }
  }
}
