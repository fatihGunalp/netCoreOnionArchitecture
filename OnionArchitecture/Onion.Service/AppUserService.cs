using Onion.Domain;
using Onion.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service
{
    public class AppUserService : IAppUserService
    {
        private readonly IRepository<AppUser> _appUserRepository;

        public AppUserService(IRepository<AppUser> appUserRepository)
        {_appUserRepository = appUserRepository;
        }

        public async Task<bool> AddUser(AppUser user)
        {
            try
            {
               var result=await _appUserRepository.Add(user);
                return result;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                var result = await _appUserRepository.Delete(id);
                return result;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<AppUser>> GetAllUsers()
        {
            return await _appUserRepository.GetAll();
        }

        public async Task<AppUser> GetById(int id)
        {
            return await _appUserRepository.GetById(id);
        }

        public async Task<bool> UpdateUser(AppUser user)
        {
            try
            {
                var result = await _appUserRepository.Update(user);
                return result;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
