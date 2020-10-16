using Onion.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service
{
    public interface IAppUserService
    {
        Task<bool> AddUser(AppUser user);
        Task<bool> UpdateUser(AppUser user);
        Task<List<AppUser>> GetAllUsers();
        Task<AppUser> GetById(int id);
        Task<bool> DeleteUser(int id);
    }
}
