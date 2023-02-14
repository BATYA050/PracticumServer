using Microsoft.EntityFrameworkCore;
using MyProjectR_B.Repositories.Entities;
using MyProjectR_B.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Repositories
{
    public class ChildrenRepository: IChildrenRepository
    {

      
            private readonly IContext _context;
            public ChildrenRepository(IContext context)
            {
                _context = context;
            }
            public async Task DeleteAsync(string id)
            {
                _context.Children.Remove(await GetByIdAsync(id));
                await _context.SaveChangesAsync();
            }

        public async Task<Children> AddAsync(string idChildren, string firstName, string lastName, DateTime date, int iduser/*, /*int iduser2*/)
        {
            Children children = new Children() { IdChildren = idChildren, FirstName = firstName, LastName = lastName, DateOfBirth = date, IdU = iduser, /*IdUser2 = iduser2*/};
            _context.Children.Add(children);
            await _context.SaveChangesAsync();
            return children;
        
        }

        public async Task<List<Children>> GetAllAsync()
            {
                return await _context.Children.Include(u=>u.user).ToListAsync(); ;
            }

            public async Task<Children> GetByIdAsync(string id)
            {
                return await _context.Children.Include(u=>u.user).FirstOrDefaultAsync(u=>u.IdChildren==id);
            }

            public async Task<Entities.Children> UpdateAsync(Children Children)
            {
                var update = _context.Children.Update(Children).Entity;
                await _context.SaveChangesAsync();
                return Children;
            }
        }
    }

