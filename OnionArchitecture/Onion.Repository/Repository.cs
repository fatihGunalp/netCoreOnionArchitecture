using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Onion.Domain;
using Onion.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> dataSet;

        public Repository(ApplicationDbContext context)
        {
            
            _context = context;
           this.dataSet= _context.Set<T>();
        }


        public async Task<bool> Add(T entity)
        {
            
            try
            {
                await dataSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var result = await dataSet.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (result != null)
                {
                    dataSet.Remove(result);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await dataSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await dataSet.FindAsync(id);
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                dataSet.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
