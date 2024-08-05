using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface  IRepository<T> where T : BaseEntity///arayüz interface tanımladık//temel base şeyleri tutsun. Evrensel olan şeyleri tutsun
    {
        DbSet<T> Table { get;}
    }
}
