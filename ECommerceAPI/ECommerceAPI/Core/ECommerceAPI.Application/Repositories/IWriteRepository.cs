using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity//typın tsi//ekleme ve silme operasyonları//bunnların somut yapılanmaları persistencenin içinde oluşur
    {
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T model);//async değilse task ekleme
    bool RemoveRange(List<T> datas); // Burada yazım hatası düzeltilmeli
    //Task<bool> RemoveAsync(string id);//bool ile true veya false dönmesi gerektiğini savunuyoruz
    bool Update(T model);
    Task<int> SaveAsync();
    }
}
