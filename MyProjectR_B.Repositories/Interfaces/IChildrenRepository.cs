using MyProjectR_B.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Interfaces
{
    public interface IChildrenRepository
    {
        Task<List<Children>> GetAllAsync();
        Task<Children> GetByIdAsync(string id);
        Task<Children> AddAsync(string idChildren, string firstName, string lastName, DateTime date, int iduser /*int iduser2*/);
        Task<Children> UpdateAsync(Children children);
        Task DeleteAsync(string id);


    }
}
