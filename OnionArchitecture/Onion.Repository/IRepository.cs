using Onion.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository
{
    public interface IRepository<T> where T:BaseEntity
    {
        
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Delete(int id);
    }
}
