using MyProjectR_B.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<User> AddAsync(string idUser, string firstName, string lastName, DateTime DateOfBirth, string min, string hmd/*,Children c=null*/);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(string id);
    }
}
