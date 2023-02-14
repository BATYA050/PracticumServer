using Microsoft.EntityFrameworkCore;
using MyProjectR_B.Repositories.Entities;
using MyProjectR_B.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProjectR_B.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }


    public async Task<User> AddAsync(string idUser, string firstName, string lastName, DateTime dateOfBirth, string min, string hmd/*,Children c*/)
        {
            User user = new User() {  IdUser = idUser, FirstName = firstName, LastName = lastName, DateOfBirth = dateOfBirth, Min = min, HMO = hmd /*, Childrens = new List<Children>((IEnumerable<Children>)c*/};
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task DeleteAsync(string id)
        {
            //Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<User> entityEntry = _context.user.Remove(await GetByIdAsync(id));

            _context.User.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

      

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.User.ToListAsync(); ;
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var update = _context.User.Update(user).Entity;
               await _context.SaveChangesAsync();
              return user;
        }
    }
   
}
